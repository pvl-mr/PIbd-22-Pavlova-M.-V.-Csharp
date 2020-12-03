﻿using System;
using System.Collections.Generic;
using System.IO;
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
		readonly Dictionary<string, Parking<ITransport>> parkingStages;

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
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
		{
			parkingStages = new Dictionary<string, Parking<ITransport>>();
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
			parkingStages.Add(name, new Parking<ITransport>(pictureWidth, pictureHeight));

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
		public Parking<ITransport> this[string ind]
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



        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
       

        /// <summary>
        /// Сохранение информации по лодкам на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
            {
                sw.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    ITransport boat = null;
                    for (int i = 0; (boat = level.Value.GetNext(i)) != null; i++)
                    {
                        if (boat != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (boat.GetType().Name == "Boat")
                            {
                                sw.Write($"Boat{separator}");
                            }
                            if (boat.GetType().Name == "Catamaran")
                            {
                                sw.Write($"Catamaran{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(boat.ToString());
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string line = sr.ReadLine();
                string key = string.Empty;
                if (line.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                while((line = sr.ReadLine()) != null)
                {
                    SwimmingTransport boat = null;

                    //идем по считанным записям
                    if (line.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<ITransport>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Boat")
                    {
                        boat = new Boat(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Catamaran")
                    {
                        boat = new Catamaran(line.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + boat;
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

}
