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
    class Edge: IComparable<Edge>
    {
        private Vertex first, second;
        public int value;
        public bool select;
        private Color color;

        public Edge(Vertex _first, Vertex _second, bool _darktheme)
        {
            first = _first;
            second = _second;
            //value = (int)(Math.Sqrt((first.x - second.x) * (first.x - second.x) + (first.y - second.y) * (first.y - second.y)));
            value = 0;
            select = false;

            color = Color.Black;
            if (_darktheme)
                color = Color.White;
        }

        public Vertex GetFirstVertex()
        {
            return first;
        }

        public Vertex GetSecondVertex()
        {
            return second;
        }

        public void SetColor(Color _color)
        {
            color = _color;
        }

        public void SetTheme(bool _darktheme)
        {
            color = Color.Black;
            if (_darktheme)
                color = Color.White;
        }

        public bool Check(int MouseX, int MouseY)
        {
            double eps = 4;
            int x1 = first.x;
            int y1 = first.y;
            int x2 = second.x;
            int y2 = second.y;

            return Math.Abs((y2 - y1) * MouseX + (x1 - x2) * MouseY + y1 * (x2 - x1) + x1 * (y1 - y2)) / Math.Sqrt((y2 - y1) * (y2 - y1) + (x1 - x2) * (x1 - x2)) <= eps &&
                (MouseX <= Math.Max(x1, x2)) && (MouseX >= Math.Min(x1, x2)) && (MouseY <= Math.Max(y1, y2)) && (MouseY >= Math.Min(y1, y2));
        }

        public void Draw(PaintEventArgs e)
        {
            int size = 2;

            if (select)
                size = 4;

            e.Graphics.DrawLine(new Pen(color, size), first.x, first.y, second.x, second.y);

            if(value != 0)
                e.Graphics.DrawString(value.ToString(), new Font("Arial", 10, FontStyle.Bold), new SolidBrush(color), (first.x + second.x) / 2, (first.y + second.y) / 2);
        }

        public bool IsVertexes(Vertex vertex1, Vertex vertex2)
        {
            return (first == vertex1 && second == vertex2) || (first == vertex2 && second == vertex1);
        }

        public bool IsVertex(Vertex _vertex)
        {
            return first == _vertex || second == _vertex;
        }

        public Vertex GetAnotherVertex(Vertex _vertex)
        {
            if (first == _vertex)
                return second;
            if (second == _vertex)
                return first;
            return null;
        }

        public int CompareTo(Edge other)
        {
            if (other == null)
                return 1;
            return this.value.CompareTo(other.value);
        }
    }
}
