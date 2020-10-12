using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
	class Catamaran
	{
        /// <summary>
        /// Левая координата отрисовки лодки
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки лодки
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна лодки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        private readonly int boatWidth = 385;
        /// <summary>
        /// Высота отрисовки лодки
        /// </summary>
        private readonly int boatHeight = 150;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес лодки
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// Признак наличия боковых поплавков
        public bool SideSpoiler { private set; get; }
        /// <summary>
        public bool LeftSideFloat { private set; get; }
        public bool RighrSideFloat { private set; get; }
        /// Признак наличия полосы
        /// </summary>
        public bool Line { private set; get; }

        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor,
 bool sideSpoiler, bool sportLine)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            SideSpoiler = sideSpoiler;
            Line = sportLine;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            _startPosX = x;
            _startPosY = y;
        }

        public void MoveTransport(Direction direction)
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
                    if(_startPosY - step > 0)
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

        public void DrawTransport(Graphics g)
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
            if (SideSpoiler)
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

        }
    }
}
