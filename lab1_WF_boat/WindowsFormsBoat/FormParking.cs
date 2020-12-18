using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCars;

namespace WindowsFormsBoat
{
	public partial class FormParking : Form
	{

		private readonly ParkingCollection parkingCollection;

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;

        public FormParking()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(boxParking.Width, boxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
            
        }

		private void ReloadLevels()
		{
			int index = listBoxParkings.SelectedIndex;
			listBoxParkings.Items.Clear();
			for (int i = 0; i < parkingCollection.Keys.Count; i++)
			{
				listBoxParkings.Items.Add(parkingCollection.Keys[i]);
			}
			if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
			{
				listBoxParkings.SelectedIndex = 0;
			}
			else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
			{
				listBoxParkings.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxParkings.SelectedIndex > -1)
			{//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
				Bitmap bmp = new Bitmap(boxParking.Width, boxParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
				boxParking.Image = bmp;
			}
		}

		private void bParkBoat_Click(object sender, EventArgs e)
		{
			var formCarConfig = new FormBoatConfig();
			formCarConfig.AddEvent(AddBoat);
			formCarConfig.Show();
		}

		private void AddBoat(SwimmingTransport boat)
		{
			if (boat != null && listBoxParkings.SelectedIndex > -1)
			{
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + boat)
                    {
                        Draw();
                        logger.Info($"Добавлена лодка {boat}");
                    }
                    else
                    {
                        
                        MessageBox.Show("Лодку поставить не удалось");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
		}

		private void bTake_Click(object sender, EventArgs e)
		{
			if (listBoxParkings.SelectedIndex > -1 && maskedTextBox_placing.Text != "")
			{
                try
                {
                    var boat = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox_placing.Text);
                    if (boat != null)
                    {
                        FormBoat form = new FormBoat();
                        form.SetBoat(boat);
                        form.ShowDialog();
                        logger.Info($"Изъята лодка {boat} с места {maskedTextBox_placing.Text}");
                        Draw();
                    }                  
                }
                catch (ParkingNotFoundException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
		}

		private void buttonDelParking_Click_Click(object sender, EventArgs e)
		{
			if (listBoxParkings.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
                
                    logger.Info($"Удалили парковку {listBoxParkings.SelectedItem.ToString()}");
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
					ReloadLevels();
				}
			}

		}

		private void buttonAddParking_Click_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
            parkingCollection.AddParking(textBoxNewLevelName.Text);
			ReloadLevels();
		}

		private void listBoxParkings_SelectedIndexChanged_1(object sender, EventArgs e)
		{
            logger.Info($"Перешли на парковку {listBoxParkings.SelectedItem.ToString()}");
            Draw();
		}

        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
            }
        }


        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSort_Click_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
