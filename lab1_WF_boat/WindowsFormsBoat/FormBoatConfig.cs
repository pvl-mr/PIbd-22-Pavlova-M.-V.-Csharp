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
	public partial class FormBoatConfig : Form
	{

		ITransport boat = null;

		private event Action<ITransport> eventAddBoat;

		public FormBoatConfig()
		{
			InitializeComponent();
			// привязать panelColor_MouseDown к панелям с цветами
			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
			panelColor1.MouseDown += panelColor_MouseDown;
			panelColor2.MouseDown += panelColor_MouseDown;
			panelColor3.MouseDown += panelColor_MouseDown;
			panelColor4.MouseDown += panelColor_MouseDown;
			panelColor5.MouseDown += panelColor_MouseDown;
			panelColor6.MouseDown += panelColor_MouseDown;
			panelColor7.MouseDown += panelColor_MouseDown;
			panelColor8.MouseDown += panelColor_MouseDown;
			buttonAdd.Click += (object sender, EventArgs e) => { eventAddBoat.Invoke(boat); Close(); };
		}

		/// <summary>
		/// Отрисовать лодку
		/// </summary>
		private void DrawBoat()
		{
			if (boat != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
				Graphics gr = Graphics.FromImage(bmp);
				boat.SetPosition(5, 5, pictureBoxBoat.Width, pictureBoxBoat.Height);
				boat.DrawTransport(gr);
				pictureBoxBoat.Image = bmp;
			}
		}

		/// <summary>
		/// Передаем информацию при нажатии на Label
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelBoat_MouseDown(object sender, MouseEventArgs e)
		{
			labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}
		/// <summary>
		/// Передаем информацию при нажатии на Label
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelCatamaran_MouseDown(object sender, MouseEventArgs e)
		{
			labelCatamaran.DoDragDrop(labelCatamaran.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		/// <summary>
		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panelBoat_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		/// <summary>
		/// Действия при приеме перетаскиваемой информации
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void panelBoat_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Лодка":
					boat = new Boat((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
					break;
				case "Катамаран":
					boat = new Catamaran((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
					checkBoxRightFloat.Checked, checkBoxLeftFloat.Checked);
					break;
			}
			DrawBoat();
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}
		/// <summary>
		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelColor_DragEnter(object sender, DragEventArgs e)
		{
			// Прописать логику проверки приходящего значения на тип Color
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else e.Effect = DragDropEffects.None;
			
		}
		/// <summary>
		/// Принимаем основной цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (boat != null)
			{
				boat.SetMainColor((Color)e.Data.GetData(typeof(Color)));
				DrawBoat();
			}
		}
		/// <summary>
		/// Принимаем дополнительный цвет
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			// Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
			if (boat is Catamaran && boat != null)
			{
				((Catamaran)boat).SetDopColor((Color)e.Data.GetData(typeof(Color)));
				DrawBoat();
			}
		}



		/// <summary>
		/// Добавление события
		/// </summary>
		/// <param name="ev"></param>
		public void AddEvent(Action<ITransport> ev)
		{
			if (eventAddBoat == null)
			{
				eventAddBoat = ev;
			}
			else
			{
				eventAddBoat += ev;
			}
		}

    }
	
}
