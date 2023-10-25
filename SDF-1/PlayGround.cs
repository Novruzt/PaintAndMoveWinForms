using SDF.Stuff.Enums;
using SDF.Stuff.Items.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rectangle = SDF.Stuff.Items.Concrete.Rectangle;

namespace SDF_1
{

    public partial class PlayGround : Form
    {
        private bool goRight, goLeft, goUp, goDown;
        private FigureType _figure;
        private Circle _circle;
        private Rectangle _rectangle;
        private int _speed = 5;
        private int _positionX = 500;
        private int _positionY = 250;

        private int _borderLeftX=70;
        private int _borderRightX=930;
        private int _borderUpY=60;
        private int _borderDownY=415;
        public PlayGround(Circle? circle, Rectangle? rectangle, int speed, FigureType figure)
        {
            _circle = circle;
            _rectangle = rectangle;
            _speed = speed;
            _figure = figure;

            this.BackgroundImage = Image.FromFile(@"C:\Users\User\Desktop\BMU TASKS\SDF-1\SDF.Stuff\İmages\FootballStadium.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.KeyDown += KeyDown_Event;

            InitializeComponent();
        }

        private void Paint_Event(object sender, PaintEventArgs e)
        {

            if (_figure == FigureType.Circle) DrawCircle(e.Graphics, _circle);
            else DrawRectangle(e.Graphics, _rectangle);

        }
        private void DrawRectangle(Graphics g, Rectangle rect)
        {
            Brush brush = (bool)rect.IsFilled ? new SolidBrush(Color.FromName(rect.Color)) : new SolidBrush(Color.Transparent);
            Pen pen = new Pen(Color.FromName(rect.Color));

            if ((bool)rect.IsFilled) g.FillRectangle(brush, _positionX, _positionY, (float)rect.Width, (float)rect.Height);
            else g.DrawRectangle(pen, _positionX, _positionY, (float)rect.Width, (float)rect.Height);
        }

        private void DrawCircle(Graphics g, Circle circle)
        {
            Brush brush = (bool)circle.IsFilled ? new SolidBrush(Color.FromName(circle.Color)) : new SolidBrush(Color.Transparent);
            Pen pen = new Pen(Color.FromName(circle.Color));

            if ((bool)circle.IsFilled) g.FillEllipse(brush, _positionX, _positionY, (int)circle.Radius * 2, (int)circle.Radius * 2);
            else g.DrawEllipse(pen, _positionX, _positionY, (int)circle.Radius * 2, (int)circle.Radius * 2);
        }


        private void KeyDown_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (_positionX - _speed > _borderLeftX) _positionX -= _speed;
                else _positionX = _borderLeftX;
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (_figure == FigureType.Rectangle)
                {
                    if (_positionX + _speed + _rectangle.Width < _borderRightX)
                    {
                        _positionX += _speed;
                    }
                    else
                    {
                        _positionX = _borderRightX - (int)_rectangle.Width;
                    }
                }
                else
                {
                    if (_positionX + _speed + _circle.Radius * 2 < _borderRightX)
                    {
                        _positionX += _speed;
                    }
                    else
                    {
                        _positionX = _borderRightX - (int)_circle.Radius * 2;
                    }
                }
            }

            else if (e.KeyCode == Keys.Up)
            {
                if (_positionY - _speed > _borderUpY) _positionY -= _speed;
                else _positionY = _borderUpY;

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (_figure == FigureType.Rectangle)
                {
                    if (_positionY + _speed + (int)_rectangle.Height < _borderDownY)
                    {
                        _positionY += _speed;
                    }
                    else
                    {
                        _positionY = _borderDownY - (int)_rectangle.Height;
                    }
                }
                else
                {
                    if (_positionY + _speed + (int)_circle.Radius * 2 < _borderDownY)
                    {
                        _positionY += _speed;
                    }
                    else
                    {
                        _positionY = _borderDownY - (int)_circle.Radius * 2;
                    }
                }
            }


            this.Refresh();
        }
    }
}
