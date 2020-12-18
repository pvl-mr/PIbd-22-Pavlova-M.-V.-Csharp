using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCars;

namespace WindowsFormsBoat
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Parking<T> : IEnumerator<T>, IEnumerable<T>
		where T : class, ITransport
	{
		/// <summary>
		/// Список объектов, которые храним
		/// </summary>
		private readonly List<T> places;
		/// <summary>
		/// Максимальное количество мест на парковке
		/// </summary>
		private readonly int maxCount;
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
		/// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
		/// </summary>
		private int _currentIndex;
		public T Current => places[_currentIndex];
		object IEnumerator.Current => places[_currentIndex];

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="picWidth">Рамзер парковки - ширина</param>
		/// <param name="picHeight">Рамзер парковки - высота</param>
		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / placeSizeWidth;
			int height = picHeight / placeSizeHeight;
			places = new List<T>();
			pictureWidth = picWidth;
			pictureHeight = picHeight;
			maxCount = width * height;

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
			if (p.places.Count >= p.maxCount)
			{
                throw new ParkingOverflowException("Переполнено");
            }

			if (p.places.Contains(boat))
			{
				throw new ParkingAlreadyHaveException();
			}
			p.places.Add(boat);
			return true;			
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
			if (index < -1 || index > p.places.Count)
			{
                throw new ParkingNotFoundException(index);
            }
			T boat = p.places[index];
			p.places.RemoveAt(index);
			return boat;
		}
		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		/// <param name="g"></param>
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < places.Count; ++i)
			{
				places[i].SetPosition(5 + i / 3 * placeSizeWidth + 5, i % 3 * placeSizeHeight + 15, pictureWidth, pictureHeight);
				places[i].DrawTransport(g);
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
				for (int j = 0; j < pictureHeight / placeSizeHeight+1; ++j)
				{//линия рамзетки места
					g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
				}
				g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, (pictureHeight / placeSizeHeight) * placeSizeHeight);
			}
		}
        public T GetNext(int index)
        {
            if (index < 0 || index >= places.Count)
            {
                return null;
            }
            return places[index];
        }

		/// <summary>
		/// Сортировка автомобилей на парковке
		/// </summary>
		public void Sort() => places.Sort((IComparer<T>)new BoatComparer());

		/// <summary>
		/// Метод интерфейса IEnumerator, вызываемый при удалении объекта
		/// </summary>
		public void Dispose()
		{
		}
		/// <summary>
		/// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
		/// </summary>
		/// <returns></returns>
		public bool MoveNext()
		{
			if (_currentIndex + 1 == places.Count)
			{			
				return false;
			}
			_currentIndex++;
			return true;
		}
		/// <summary>
		/// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
		/// </summary>
		public void Reset()
		{
			_currentIndex = -1;
		}
		/// <summary>
		/// Метод интерфейса IEnumerable
		/// </summary>
		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}
		/// <summary>
		/// Метод интерфейса IEnumerable
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}
	}

}
