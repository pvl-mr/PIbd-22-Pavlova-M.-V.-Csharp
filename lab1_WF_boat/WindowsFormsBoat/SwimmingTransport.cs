using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
	public abstract class SwimmingTransport : ITransport
	{
		/// Левая координата отрисовки лодки
		/// </summary>
		protected float _startPosX;
		/// <summary>
		/// Правая кооридната отрисовки лодки
		/// </summary>
		protected float _startPosY;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		protected int _pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		protected int _pictureHeight;
		/// <summary>
		/// Максимальная скорость
		/// </summary>
		public int MaxSpeed { protected set; get; }
		/// <summary>
		/// Вес лодки
		/// </summary>
		public float Weight { protected set; get; }
		/// <summary>
		/// Основной цвет кузова
		/// </summary>
		public Color MainColor { protected set; get; }

		public abstract void DrawTransport(Graphics g);

		public abstract void MoveTransport(Direction direction);
		
		public void SetPosition(int x, int y, int width, int height)
		{
			_pictureWidth = width;
			_pictureHeight = height;
			_startPosX = x;
			_startPosY = y;
		}

		public void SetMainColor(Color color)
		{
			MainColor = color;
		}

	}
}
