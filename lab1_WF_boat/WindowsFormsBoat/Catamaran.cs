using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
	public class Catamaran : Boat, IEquatable<Catamaran>
    {  
        public Color DopColor { private set; get; }

        public bool SideFloat { private set; get; }
 
        public bool LeftSideFloat { private set; get; }

        public bool RighrSideFloat { private set; get; }

        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool righrSideFloat, bool leftSideFloat) : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            RighrSideFloat = righrSideFloat;
            LeftSideFloat = leftSideFloat;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Catamaran(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                RighrSideFloat = Convert.ToBoolean(strs[4]);
                LeftSideFloat = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);                   

            if (SideFloat)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX, _startPosY-2, 400, 20);
                g.FillRectangle(spoiler, _startPosX, _startPosY+122, 400, 20);
            }

            if (RighrSideFloat)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX, _startPosY - 2, 400, 20);
            }

            if (LeftSideFloat)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX, _startPosY + 122, 400, 20);
            }
            // основная часть плавательного средства
            base.DrawTransport(g);

        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{RighrSideFloat}{separator}{LeftSideFloat}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Catamaran other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (RighrSideFloat != other.RighrSideFloat)
            {
                return false;
            }
            if (LeftSideFloat != other.LeftSideFloat)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
            return false;
            }
            if (!(obj is Catamaran boatObj))
            {
                return false;
            }
            else
            {
                return Equals(boatObj);
            }
        }

    }
}
