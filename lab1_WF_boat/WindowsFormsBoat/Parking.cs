using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
	public class Parking<T> where T : class, ITransport
	{
		private readonly T[] places;
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Размер парковочного места (ширина)
		/// </summary>
		private const int placeSizeWidth = 500;
		/// <summary>
		/// Размер парковочного места (высота)
		/// </summary>
		private const int placeSizeHeight = 170;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="picWidth">Рамзер парковки - ширина</param>
		/// <param name="picHeight">Рамзер парковки - высота</param>
		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / placeSizeWidth;
			int height = picHeight / placeSizeHeight;
			places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}
		/// <summary>
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется автомобиль
		/// </summary>
		/// <param name="p">Парковка</param>
		/// <param name="car">Добавляемый автомобиль</param>
		/// <returns></returns>
		public static bool operator +(Parking<T> p, T boat)
		{
			int numberOfstring= p.pictureHeight / placeSizeHeight;

			for (int i = 0; i < p.places.Length; i++)
			{
				if (p.places[i] == null)
				{
					MessageBox.Show(i.ToString());
					boat.SetPosition((i / numberOfstring) *placeSizeWidth+10, (i % numberOfstring)*placeSizeHeight+15, p.pictureWidth, p.pictureHeight);
					p.places[i] = boat;
					return true;
				}
			}
			return false;
			
		}
		/// <summary>
		/// Перегрузка оператора вычитания
		/// Логика действия: с парковки забираем автомобиль
		/// </summary>
		/// <param name="p">Парковка</param>
		/// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
		/// <returns></returns>
		public static T operator -(Parking<T> p, int index)
		{
			if (index >= p.places.Length)
			{
				return null;
			}
			T pl = p.places[index];
			pl.SetPosition(10, 10, p.pictureWidth, p.pictureHeight);
			p.places[index] = null;
			// Прописать логику для вычитания
			return pl;
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < places.Length; i++)
			{
				places[i]?.DrawTransport(g);
			}
		}
		/// <summary>
		/// Метод отрисовки разметки парковочных мест
		/// </summary>
		/// <param name="g"></param>
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / placeSizeWidth; i++)
				
		{
				for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
				{//линия рамзетки места
					g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
				}
				g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, (pictureHeight / placeSizeHeight) * placeSizeHeight);
			}
		}
	}



}
