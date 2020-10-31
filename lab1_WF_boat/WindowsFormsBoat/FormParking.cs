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

		private readonly Parking<Boat> parking;

		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<Boat>(boxParking.Width, boxParking.Height);
			Draw();
		}


		private void Draw()
		{
			Bitmap bmp = new Bitmap(boxParking.Width, boxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			boxParking.Image = bmp;
		}

		private void bParkBoat_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var boat = new Boat(100, 1000, dialog.Color);

				if (parking + boat)
					{
					Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
		}

		private void bParkCatamaran_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var boat = new Catamaran(100, 1000, dialog.Color, dialogDop.Color, true, true);
					if (parking + boat)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}

		private void bTake_Click(object sender, EventArgs e)
		{
			if (maskedTextBox_placing.Text != "")
			{
				var boat = parking - Convert.ToInt32(maskedTextBox_placing.Text);
				
				if (boat != null)
				{
					FormBoat form = new FormBoat();
					form.SetBoat(boat);
					form.ShowDialog();
				}

				Draw();
			}
		}

		
	}
}
