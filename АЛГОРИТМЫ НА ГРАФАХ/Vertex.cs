using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace АЛГОРИТМЫ_НА_ГРАФАХ
{
    class Vertex
    {
        public int x, y;
        private int r;
        public bool select;
        public bool mark;
        public int number;
        public int prev_vertex;
        public int distance;
        public int component;
        private Color color;
        private string shape;
        private int size_num;

        public Vertex(int _x, int _y, int _size, string _shape, bool _darktheme)
        {
            x = _x;
            y = _y;
            select = false;
            mark = false;
            prev_vertex = 0;

            shape = "Circle";
            if (_shape == "Square")
                shape = _shape;

            switch (_size)
            {
                case 0: { r = 15; size_num = 10; break; }

                case 2: { r = 25; size_num = 19; break; }

                default: { r = 20; size_num = 15; break; }
            }

            if (_darktheme)
                color = Color.White;
            else
                color = Color.Black;
        }

        public void SetSize(int size)
        {
            switch (size)
            {
                case 0: { r = 15; size_num = 10; break; }

                case 2: { r = 25; size_num = 19; break; }

                default: { r = 20; size_num = 15; break; }
            }
        }

        public int GetSize()
        {
            return r;
        }

        public void SetShape(string _shape)
        {
            shape = "Circle";
            if (_shape == "Square")
                shape = _shape;
        }

        public void SetColor(bool _darktheme)
        {
            color = Color.Black;

            if (_darktheme)
                color = Color.White;
        }

        public bool Check(int MouseXpos, int MouseYpos)
        {
            if (shape == "Square")
                return Math.Pow(x - MouseXpos, 2) + Math.Pow(y - MouseYpos, 2) <= r * r;
                
            return (x <= MouseXpos + r) && (x >= MouseXpos - r) && (y <= MouseYpos + r) && (y >= MouseYpos - r);
        }

        public void Draw(PaintEventArgs e)
        {
            int size = 2;
            Color _color = Color.Green;

            if (select)
            {
                size = 6;
                _color = Color.Blue;
            }

            if (shape == "Square")
            {
                e.Graphics.DrawRectangle(new Pen(color, size), x - r, y - r, r * 2, r * 2);
                e.Graphics.FillRectangle(new SolidBrush(_color), x - r, y - r, r * 2, r * 2);

            }
            else // shape == "Circle" or etc.
            {
                e.Graphics.DrawEllipse(new Pen(color, size), x - r, y - r, r * 2, r * 2);
                e.Graphics.FillEllipse(new SolidBrush(_color), x - r, y - r, r * 2, r * 2);
            }

            e.Graphics.DrawString(number.ToString(), new Font("Arial", size_num), new SolidBrush(Color.White), x - r / 2 - 2, y - r / 2 - 2);
        }
    }
}
