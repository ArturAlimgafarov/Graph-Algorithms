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
    class Basket
    {
        private Image image;
        private int x = 650, y = 400, r = 25;
        public bool visible = false;

        public Basket(Image _image)
        {
            image = _image;
        }

        public bool IsCrossed(Vertex _vertex)
        {
            return Math.Sqrt(Math.Pow(_vertex.x - x - r, 2) + Math.Pow(_vertex.y - y - r, 2)) <= r + _vertex.GetSize();
        }

        public void SetImage(Image _image)
        {
            image = _image;
        }

        public void Draw(PaintEventArgs e)
        {
            if(visible)
                e.Graphics.DrawImage(image, x, y);
        }
    }
}
