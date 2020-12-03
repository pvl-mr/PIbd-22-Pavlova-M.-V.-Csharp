using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
	public partial class FormParking : Form
	{

		private readonly ParkingCollection parkingCollection;

		public FormParking()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(boxParking.Width, boxParking.Height);
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

		private void AddBoat(ITransport boat)
		{
			if (boat != null && listBoxParkings.SelectedIndex > -1)
			{
				if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + boat)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Лодку поставить не удалось");
				}
			}
		}

		private void bTake_Click(object sender, EventArgs e)
		{
			if (listBoxParkings.SelectedIndex > -1 && maskedTextBox_placing.Text != "")
			{
				var boat = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox_placing.Text);
				if (boat != null)
				{
					FormBoat form = new FormBoat();
					form.SetBoat(boat);
					form.ShowDialog();
				}
				Draw();
			}
		}

		private void FormParking_Load(object sender, EventArgs e)
		{

		}

		

		private void buttonDelParking_Click_Click(object sender, EventArgs e)
		{
			if (listBoxParkings.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
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
parkingCollection.AddParking(textBoxNewLevelName.Text);
			ReloadLevels();
		}

		private void listBoxParkings_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			Draw();
		}
	}
}
