using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
	public class Catamaran : Boat
	{
        
        public Color DopColor { private set; get; }
        /// Признак наличия боковых поплавков
        /// 
        public bool SideFloat { private set; get; }
        /// <summary>
        /// 
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


    }
}
