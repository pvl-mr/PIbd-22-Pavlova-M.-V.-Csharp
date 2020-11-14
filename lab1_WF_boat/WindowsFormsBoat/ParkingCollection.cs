﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
	class ParkingCollection
	{
		/// <summary>
		/// Словарь (хранилище) с парковками
		/// </summary>
		readonly Dictionary<string, Parking<SwimmingTransport>> parkingStages;

		/// <summary>
		/// Возвращение списка названий праковок
		/// </summary>
		public List<string> Keys => parkingStages.Keys.ToList();
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth;
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="pictureWidth"></param>
		/// <param name="pictureHeight"></param>
		public ParkingCollection(int pictureWidth, int pictureHeight)
		{
			parkingStages = new Dictionary<string, Parking<SwimmingTransport>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		/// <summary>
		/// Добавление парковки
		/// </summary>
		/// <param name="name">Название парковки</param>
		public void AddParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				return;
			}
			parkingStages.Add(name, new Parking<SwimmingTransport>(pictureWidth, pictureHeight));

		}

		/// <summary>
		/// Удаление парковки
		/// </summary>
		/// <param name="name">Название парковки</param>
		public void DelParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				parkingStages.Remove(name);
			}
		}

		/// <summary>
		/// Доступ к парковке
		/// </summary>
		/// <param name="ind"></param>
		/// <returns></returns>
		/// 

		


		public Parking<SwimmingTransport> this[string ind]
		{
			get
			{
				if (parkingStages.ContainsKey(ind))
				{
					return parkingStages[ind];
				}
				return null;

			}
		}

	}

}
