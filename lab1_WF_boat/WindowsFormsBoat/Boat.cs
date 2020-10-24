using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
	public class Boat : SwimmingTransport
	{
		/// <summary>
		/// Ширина отрисовки лодки
		/// </summary>
		protected readonly int boatWidth = 385;
		/// <summary>
		/// Высота отрисовки лодки
		/// </summary>
		protected readonly int boatHeight = 150;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес лодки</param>
		/// <param name="mainColor">Основной цвет плавательного средства</param>
		public Boat(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		/// <summary>
		/// Конструкторс изменением размеров лодки
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес лодки</param>
		/// <param name="mainColor">Основной цвет плавательного средства</param>
		/// <param name="carWidth">Ширина отрисовки лодки</param>
		/// <param name="carHeight">Высота отрисовки лодки</param>
		protected Boat(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.boatWidth = carWidth;
			this.boatHeight = carHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - boatWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - boatHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);

			PointF[] curvePoints =
					 {
			new PointF(_startPosX, _startPosY+50),
			new PointF(_startPosX + 160, _startPosY + 20),
			new PointF(_startPosX + 250, _startPosY + 20),
			new PointF(_startPosX + 390, _startPosY + 70),
			new PointF(_startPosX + 250, _startPosY + 120),
			new PointF(_startPosX + 160, _startPosY + 120),
			new PointF(_startPosX, _startPosY+90),

			 };

			g.FillPolygon(new SolidBrush(Color.Aqua), curvePoints);
			g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 160, _startPosY + 120);
			g.DrawLine(pen, _startPosX + 180, _startPosY + 20, _startPosX + 180, _startPosY + 120);
			g.DrawLine(pen, _startPosX + 300, _startPosY + 40, _startPosX + 300, _startPosY + 104);
		}
	}
}

