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
    public partial class Form1 : Form
    {
        List<Vertex> vertex = new List<Vertex>();
        List<Edge> edge = new List<Edge>();
        List<Vertex> path = new List<Vertex>();
        Basket basket;

        const int MaxSize = 25;
        string VertexShape;
        int SelectedVertexCount;
        int SelectedEdgeCount;
        int IND;
        bool DarkTheme;

        public Form1()
        {
            InitializeComponent();
            checkedListBox_VertexForm.SetItemChecked(0, true);
            
            vertex = new List<Vertex>();
            edge = new List<Edge>();
            path = new List<Vertex>();
            basket = new Basket(pictureBox_Basket.Image);

            VertexShape = "Circle";
            SelectedVertexCount = 0;
            SelectedEdgeCount = 0;
            IND = -1;
            DarkTheme = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int j = 0;

            foreach (Vertex _vertex in vertex)
                if (_vertex.Check(e.X, e.Y))
                {
                    j++;
                    _vertex.select = !_vertex.select;
                    break;
                }

            foreach (Edge _edge in edge)
                if (_edge.Check(e.X, e.Y) && j == 0)
                {
                    j++;
                    _edge.select = !_edge.select;
                    textBox_ChangeWeight.Focus();
                    break;
                }

            if ((pictureBox1.Width - MaxSize >= e.X) && (pictureBox1.Height - MaxSize >= e.Y) && (e.X >= MaxSize) && (e.Y >= MaxSize) && j == 0)
                vertex.Add(new Vertex(e.X, e.Y, trackBar_VertexSize.Value, VertexShape, DarkTheme));

            SelectedVertexCount = 0;
            for (int i = 0; i < vertex.Count; i++)
            {
                if (vertex[i].select)
                    SelectedVertexCount++;
                vertex[i].number = i + 1;
            }

            SelectedEdgeCount = 0;
            foreach (Edge _edge in edge)
                if (_edge.select)
                    SelectedEdgeCount++;

            pictureBox1.Refresh();
        }

        private void checkedListBoxVertexForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            VertexShape = "Circle";

            if (checkedListBox_VertexForm.SelectedIndex == 1)
            {
                checkedListBox_VertexForm.SetItemChecked(0, false);
                VertexShape = "Square";
            }
            else
                checkedListBox_VertexForm.SetItemChecked(1, false);

            foreach (Vertex _vertex in vertex)
                _vertex.SetShape(VertexShape);

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            basket.Draw(e);

            foreach (Edge _edge in edge)
                _edge.Draw(e);

            foreach (Vertex _vertex in vertex)
                _vertex.Draw(e);
        }

        private void trackBar_VertexSize_Scroll(object sender, EventArgs e)
        {
            foreach (Vertex _vertex in vertex)
                _vertex.SetSize(trackBar_VertexSize.Value);

            pictureBox1.Refresh();
        }

        private void button_Join_Click(object sender, EventArgs e)
        {
            if (SelectedVertexCount == 2)
            {
                foreach (Vertex i in vertex)
                    if (i.select)
                        foreach (Vertex j in vertex)
                            if (j.select && i != j)
                            {
                                Edge _edge = new Edge(i, j, DarkTheme);
                                edge.Add(_edge);
                                if (checkBox_RandomWeights.Checked)
                                    _edge.value = new Random().Next(1, 100);
                                i.select = false;
                                j.select = false;
                                break;
                            }

                pictureBox1.Refresh();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vertex.Count(); i++)
                if (vertex[i].select)
                {
                    for (int j = 0; j < edge.Count; j++)
                        if (edge[j].IsVertex(vertex[i]))
                        {
                            edge.Remove(edge[j]);
                            j--;
                        }

                    vertex.Remove(vertex[i]);
                    i--;
                }

            for (int i = 0; i < edge.Count(); i++)
                if (edge[i].select)
                {
                    edge.Remove(edge[i]);
                    i--;
                }

            for (int i = 0; i < vertex.Count(); i++)
                vertex[i].number = i + 1;

            pictureBox1.Refresh();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            vertex.Clear();
            edge.Clear();
            textBox_Console.Clear();

            pictureBox1.Refresh();
        }

        private void button_ChangeWeight_Click(object sender, EventArgs e)
        {
            if (SelectedEdgeCount == 1)
            {
                bool flag = true;
                string s = textBox_ChangeWeight.Text;

                foreach (char c in s)
                    if ((int)c < 48 || (int)c > 58)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    foreach (Edge _edge in edge)
                    {
                        if (_edge.select)
                        {
                            _edge.select = !_edge.select;
                            _edge.value = Int32.Parse(s);
                            textBox_ChangeWeight.Text = "";
                            break;
                        }
                    }
                else
                    MessageBox.Show("Неверный формат ввода!" + '\r' + '\n' + "Можно использовать только символы от 0 до 9!");

                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IND != -1 && checkBox_MoveOff.Checked)
                if (e.Button == MouseButtons.Left && (pictureBox1.Width - MaxSize >= e.X) && (pictureBox1.Height - MaxSize >= e.Y) && (e.X >= MaxSize) && (e.Y >= MaxSize))
                {
                    vertex[IND].select = true;
                    vertex[IND].x = e.X;
                    vertex[IND].y = e.Y;

                    basket.visible = true;

                    if (basket.IsCrossed(vertex[IND]))
                        basket.SetImage(pictureBox_OpenBasket.Image);
                    else
                        basket.SetImage(pictureBox_Basket.Image);

                    pictureBox1.Refresh();
                }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IND = -1;

            for (int i = 0; i < vertex.Count(); i++)
                if (vertex[i].Check(e.X, e.Y))
                {
                    IND = i;
                    break;
                }
        }

        private void checkBox_DarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DarkTheme.Checked)
            {
                DarkTheme = true;
                pictureBox1.BackColor = Color.Black;
                textBox_Console.BackColor = Color.Black;
                textBox_Console.ForeColor = Color.White;
                checkBox_DarkTheme.ForeColor = Color.White;
                checkBox_MoveOff.ForeColor = Color.White;
                checkBox_RandomWeights.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                checkedListBox_VertexForm.ForeColor = Color.White;
                checkedListBox_VertexForm.BackColor = Color.MidnightBlue;
                trackBar_VertexSize.BackColor = Color.MidnightBlue;
                Form1.ActiveForm.BackColor = Color.MidnightBlue;
            }
            else
            {
                DarkTheme = false;
                pictureBox1.BackColor = Color.White;
                textBox_Console.BackColor = Color.White;
                textBox_Console.ForeColor = Color.Black;
                checkBox_DarkTheme.ForeColor = Color.Black;
                checkBox_MoveOff.ForeColor = Color.Black;
                checkBox_RandomWeights.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                checkedListBox_VertexForm.ForeColor = Color.Black;
                checkedListBox_VertexForm.BackColor = Color.Silver;
                trackBar_VertexSize.BackColor = Color.Silver;
                Form1.ActiveForm.BackColor = Color.Silver;
            }

            foreach (Vertex _vertex in vertex)
                _vertex.SetColor(DarkTheme);

            foreach (Edge _edge in edge)
                _edge.SetTheme(DarkTheme);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int x = 0;
            int y = 0;

            switch (keyData)
            {
                case Keys.Up: { y = -1; break; }

                case Keys.Down: { y = 1; break; }

                case Keys.Right: { x = 1; break; }

                case Keys.Left: { x = -1; break; }

                case Keys.Enter:
                    {
                        bool flag = true;
                        string s = textBox_ChangeWeight.Text;

                        foreach (char c in s)
                            if ((int)c < 48 || (int)c > 58)
                            {
                                flag = false;
                                break;
                            }

                        if (flag)
                        {
                            foreach (Edge i in edge)
                                if (i.select)
                                {
                                    i.select = !i.select;
                                    i.value = Int32.Parse(textBox_ChangeWeight.Text);
                                    textBox_ChangeWeight.Text = "";
                                    break;
                                }
                        }
                        else
                            MessageBox.Show("Неверный формат ввода!" + '\r' + '\n' + "Можно использовать только символы от 0 до 9!");

                        break;
                    }

                // темная тема
                case Keys.D: { checkBox_DarkTheme.Checked = !checkBox_DarkTheme.Checked; break; }

                // вкл/выкл перемещение
                case Keys.M: { checkBox_MoveOff.Checked = !checkBox_MoveOff.Checked; break; }

                // соединить
                case Keys.J:
                    {
                        if (SelectedVertexCount == 2)
                        {
                            foreach (Vertex i in vertex)
                                if (i.select)
                                    foreach (Vertex j in vertex)
                                        if (j.select && i != j)
                                        {
                                            Edge _edge = new Edge(i, j, DarkTheme);
                                            edge.Add(_edge);
                                            if (checkBox_RandomWeights.Checked)
                                                _edge.value = new Random().Next(1, 100);
                                            i.select = false;
                                            j.select = false;
                                            break;
                                        }

                            pictureBox1.Refresh();
                        }
                        break;
                    }

                // удалить
                case Keys.X:
                    {
                        for (int i = 0; i < vertex.Count(); i++)
                            if (vertex[i].select)
                            {
                                for (int j = 0; j < edge.Count; j++)
                                    if (vertex[i] == edge[j].GetFirstVertex() || vertex[i] == edge[j].GetSecondVertex())
                                    {
                                        edge.Remove(edge[j]);
                                        j--;
                                    }

                                vertex.Remove(vertex[i]);
                                i--;
                            }

                        for (int i = 0; i < edge.Count(); i++)
                            if (edge[i].select)
                            {
                                edge.Remove(edge[i]);
                                i--;
                            }

                        for (int i = 0; i < vertex.Count(); i++)
                            vertex[i].number = i + 1;

                        pictureBox1.Refresh();

                        break;
                    }

                // очистить
                case Keys.C:
                    {
                        vertex.Clear();
                        edge.Clear();
                        textBox_Console.Clear();

                        pictureBox1.Refresh();

                        break;
                    }

                // случайный вес
                case Keys.R:
                    { checkBox_RandomWeights.Checked = !checkBox_RandomWeights.Checked; break; }

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            if (checkBox_MoveOff.Checked)
                foreach (Vertex _vertex in vertex)
                    if (_vertex.select && (pictureBox1.Width - MaxSize >= _vertex.x + x) && (pictureBox1.Height - MaxSize >= _vertex.y + y) && (_vertex.x + x >= MaxSize) && (_vertex.y + y >= MaxSize))
                    {
                        _vertex.x += x;
                        _vertex.y += y;
                    }

            pictureBox1.Refresh();

            return true;
        }

        private void Kruskal()
        {
            int first_component = 0, second_component = 0;
            Color color = Color.Black;
            if (DarkTheme)
                color = Color.White;

            double sum = 0;

            textBox_Console.Text = "Остов:" + '\r' + '\n';

            edge.Sort(); // сортировка ребер по длине в порядке возрастания

            // каждой вершине присваиваем "цвет"
            for (int i = 0; i < vertex.Count; i++)
                vertex[i].component = i;

            int k = 0;
            foreach (Edge _edge in edge)
            {
                // проверка кол-ва ребер в остовном дереве(N - 1)
                if (k == vertex.Count - 1)
                    break;

                _edge.select = true;
                Thread.Sleep(500);
                pictureBox1.Refresh();

                // проверка на образование цикла и добавление вершины в остов
                if (_edge.GetFirstVertex().component != _edge.GetSecondVertex().component)
                {
                    _edge.GetFirstVertex().select = true;
                    _edge.GetSecondVertex().select = true;
                    first_component = _edge.GetFirstVertex().component;
                    second_component = _edge.GetSecondVertex().component;
                    k++;

                    textBox_Console.Text += "(" + _edge.GetFirstVertex().number.ToString() + ", " + _edge.GetSecondVertex().number.ToString() + ")" + '\r' + '\n';

                    sum += _edge.value;
                }
                else
                {
                    _edge.SetColor(Color.Red);
                    Thread.Sleep(500);
                    pictureBox1.Refresh();
                    _edge.SetColor(color);
                    _edge.select = false;
                }

                
                Thread.Sleep(500);
                textBox_Console.Refresh();
                pictureBox1.Refresh();

                // перекрашивание вершин
                foreach (Vertex _vertex in vertex)
                    if (_vertex.component == second_component)
                        _vertex.component = first_component;
                
            }
            textBox_Console.Text += "Общая длина остова = " + sum.ToString();
            textBox_Console.Refresh();

            pictureBox1.Refresh();
        }

        private void DFS(Vertex start)
        {
            start.select = true;
            Thread.Sleep(500);
            pictureBox1.Refresh();

            foreach (Edge _edge in edge)
            {
                if (_edge.GetAnotherVertex(start) != null && !_edge.GetAnotherVertex(start).select)
                {
                    _edge.select = true;
                    textBox_Console.Text += _edge.GetFirstVertex().number.ToString() + " -> " + _edge.GetSecondVertex().number.ToString() + '\r' + '\n';
                    Thread.Sleep(500);
                    pictureBox1.Refresh();
                    textBox_Console.Refresh();

                    DFS(_edge.GetAnotherVertex(start));
                    
                    _edge.select = false;
                    Thread.Sleep(300);
                    pictureBox1.Refresh(); 
                }
            }
        }

        private void DFS2(Vertex start)
        {
            start.mark = true;

            foreach (Edge _edge in edge)
                if (_edge.GetAnotherVertex(start) != null && !_edge.GetAnotherVertex(start).mark)
                    DFS2(_edge.GetAnotherVertex(start));
        }

        private void BFS(Vertex start)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            Vertex V;

            start.select = true;
            Thread.Sleep(500);
            pictureBox1.Refresh();

            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                V = queue.Peek();
                queue.Dequeue();

                foreach (Edge _edge in edge)
                    if (_edge.GetAnotherVertex(V) != null && !_edge.GetAnotherVertex(V).select)
                    {
                        _edge.GetAnotherVertex(V).select = true;
                        _edge.select = true;

                        textBox_Console.Text += _edge.GetFirstVertex().number.ToString() + " -> " + _edge.GetSecondVertex().number.ToString() + '\r' + '\n';
                        Thread.Sleep(500);
                        pictureBox1.Refresh();
                        textBox_Console.Refresh();

                        queue.Enqueue(_edge.GetAnotherVertex(V));


                        _edge.select = false;
                        Thread.Sleep(300);
                        pictureBox1.Refresh();
                    }
            }
        }

        private void BFS2(Vertex start)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            Vertex V;

            start.mark = true;

            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                V = queue.Peek();
                queue.Dequeue();

                foreach (Edge _edge in edge)
                    if (_edge.GetAnotherVertex(V) != null && !_edge.GetAnotherVertex(V).mark)
                    {
                        _edge.GetAnotherVertex(V).mark = true;
                        queue.Enqueue(_edge.GetAnotherVertex(V));
                    }
            }
        }

        private int VertexDegree(Vertex _vertex)
        {
            int k = 0;

            foreach (Edge _edge in edge)
                if (_edge.GetAnotherVertex(_vertex) != null)
                    k++;
            return k;
        }

        private bool GraphConnectCheck()
        {
            int StartIndex = Int32.Parse(textBox_Input1.Text) - 1;

            DFS2(vertex[StartIndex]);
            //BFS2(vertex[StartIndex]);

            foreach (Vertex _vertex in vertex)
                if (!_vertex.mark)
                    return false;
            return true;
        }

        private bool EulerTest()
        {
            int OddVertexes = 0; // счетчик вершин нечетных степеней

            foreach (Vertex _vertex in vertex)
                if (VertexDegree(_vertex) % 2 != 0)
                    OddVertexes++;

            if (OddVertexes != 0)
                MessageBox.Show("Граф не содержит Эйлерова цикла, так как не все вершины имеют четную степень.");
            if (!GraphConnectCheck())
                MessageBox.Show("Граф не содержит Эйлерова цикла, так как граф несвязный.");

            return (OddVertexes == 0) && GraphConnectCheck();
        }

        private void Search_Euler(Vertex start)
        {
            foreach(Edge _edge in edge)
                if(_edge.GetAnotherVertex(start) != null && !_edge.select)
                {
                    _edge.select = true;
                    Thread.Sleep(500);
                    pictureBox1.Refresh();

                    Search_Euler(_edge.GetAnotherVertex(start));
                }

            path.Add(start);
        }

        private Vertex MinVertexDist(List<Vertex> list)
        {
            double min = Int32.MaxValue;
            Vertex MinVertex = null;

            foreach (Vertex _vertex in list)
                if (_vertex.distance < min && !_vertex.mark)
                {
                    MinVertex = _vertex;
                    min = _vertex.distance;
                }

            return MinVertex;
        }

        /*private void Dijkstra()
        {
            textBox_Console.Text = "START: " + textBox_Input1.Text + "     END: " + textBox_Input2.Text + '\r' + '\n' + '\r' + '\n';
            path.Clear();

            int N = vertex.Count;
            int M = edge.Count;
            int INF = 1000000;

            for (int i = 0; i < N; i++)
            {
                vertex[i].mark = false;
                vertex[i].prev_vertex = 0;
                vertex[i].distance = INF;
            }

            int[][] a = new int[N][];
            for (int i = 0; i < N; i++)
                a[i] = new int[N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    a[i][j] = INF;

            foreach (Vertex _vertex in vertex)
                foreach (Edge _edge in edge)
                    if (_edge.GetAnotherVertex(_vertex) != null)
                    {
                        if (_edge.GetAnotherVertex(_vertex).number != _vertex.number)
                        {
                            a[_vertex.number - 1][_edge.GetAnotherVertex(_vertex).number - 1] = _edge.value;
                            a[_edge.GetAnotherVertex(_vertex).number - 1][_vertex.number - 1] = _edge.value;
                        }
                        else
                        {
                            a[_vertex.number - 1][_edge.GetAnotherVertex(_vertex).number - 1] = 0;
                            a[_edge.GetAnotherVertex(_vertex).number - 1][_vertex.number - 1] = 0;
                        }
                    }

            int start = Int32.Parse(textBox_Input1.Text) - 1;
            int end = Int32.Parse(textBox_Input2.Text) - 1;

            int y = start;
            int min = INF;

            vertex[y].mark = true;
            vertex[y].distance = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (!vertex[j].mark)
                    {
                        if (Math.Min(vertex[j].distance, vertex[y].distance + a[y][j]) < vertex[j].distance)
                            vertex[j].prev_vertex = y;

                        vertex[j].distance = Math.Min(vertex[j].distance, vertex[y].distance + a[y][j]);
                    }
                }

                min = INF;
                for (int k = 0; k < N; k++)
                    if (vertex[k].distance < min && !vertex[k].mark)
                    {
                        y = k;
                        min = vertex[k].distance;
                    }
                vertex[y].mark = true;
            }

            for (int i = end; i != start; i = vertex[i].prev_vertex)
                path.Add(vertex[i]);
            path.Add(vertex[start]);
            path.Reverse();
            for (int i = 0; i < path.Count - 1; i++)
                textBox_Console.Text += path[i].number.ToString() + " -> ";
            textBox_Console.Text += vertex[end].number.ToString() + " = " + vertex[end].distance.ToString();
            textBox_Console.Refresh();

            for (int i = 1; i < path.Count; i++)
                for (int j = 0; j < M; j++)
                    if (edge[j].IsVertexes(path[i], path[i - 1]))
                    {
                        path[i - 1].select = true;
                        path[i].select = true;
                        edge[j].select = true;
                    }
            pictureBox1.Refresh();
        }*/ // first version

        private void Dijkstra(Vertex Start, Vertex End)
        {
            textBox_Console.Text = "START: " + textBox_Input1.Text + "  END: " + textBox_Input2.Text + '\r' + '\n' + '\r' + '\n';
            path.Clear();

            int INF = 1000000; // бесконечность
            foreach (Vertex i in vertex)
            {
                i.mark = false;
                i.distance = INF;
            }

            Vertex _vertex = Start;

            _vertex.mark = true;
            _vertex.distance = 0;

            while (!End.mark) // пока не найдено кратчайшее расстояние
            {
                foreach (Edge _edge in edge)
                    if (_edge.GetAnotherVertex(_vertex) != null) // если ребро существует
                    {
                        Vertex neighbor_vertex = _edge.GetAnotherVertex(_vertex);

                        if (!neighbor_vertex.mark && _vertex.distance + _edge.value < neighbor_vertex.distance)
                        {
                            neighbor_vertex.distance = _vertex.distance + _edge.value;
                            neighbor_vertex.prev_vertex = _vertex.number - 1;
                        }
                    }

                _vertex = MinVertexDist(vertex);
                _vertex.mark = true;
            }

            for (int i = End.number - 1; i != Start.number - 1; i = vertex[i].prev_vertex) 
                path.Add(vertex[i]);
            path.Add(Start);
            path.Reverse();


            for (int i = 0; i < path.Count - 1; i++)
                textBox_Console.Text += path[i].number.ToString() + " -> ";

            textBox_Console.Text += End.number.ToString() + " = " + End.distance.ToString();
            textBox_Console.Refresh();

            for (int i = 1; i < path.Count; i++)
                for (int j = 0; j < edge.Count; j++)
                    if (edge[j].IsVertexes(path[i], path[i - 1]))
                    {
                        path[i - 1].select = true;
                        path[i].select = true;
                        edge[j].select = true;
                    }
            pictureBox1.Refresh();

        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            textBox_Console.Clear();

            ///////// снятие выделений ///////
            foreach (Edge _edge in edge)
                _edge.select = false;
            foreach (Vertex _vertex in vertex)
                _vertex.select = _vertex.mark = false;
            /////////////////////////////////

            domainUpDown_Algo.Enabled = false;
            checkedListBox_VertexForm.Enabled = false;
            trackBar_VertexSize.Enabled = false;
            checkBox_DarkTheme.Enabled = false;

            switch (domainUpDown_Algo.SelectedIndex)
            {
                case 1: 
                    { 
                        Kruskal(); 
                        break; 
                    }

                case 2:
                    {
                        bool flag = true;
                        string s = textBox_Input1.Text;

                        if (s == "")
                            MessageBox.Show("Введите номер стартовой вершины!");
                        else
                        {
                            foreach (char c in s)
                                if ((int)c < 48 || (int)c > 58)
                                {
                                    flag = false;
                                    break;
                                }

                            if (flag)
                            {
                                if (Int32.Parse(s) - 1 < 0 || Int32.Parse(s) > vertex.Count)
                                    MessageBox.Show("Вершины с таким номером нет!");
                                else
                                {
                                    int StartIndex = Int32.Parse(s) - 1;
                                    textBox_Console.Text = "START: " + (StartIndex + 1).ToString() + '\r' + '\n';
                                    textBox_Console.Refresh();

                                    DFS(vertex[StartIndex]);
                                }
                            }
                            else
                                MessageBox.Show("Неверный формат ввода!" + '\r' + '\n' + "Можно использовать только символы от 0 до 9!");
                        }

                        break;
                    }

                case 3:
                    {
                        bool flag = true;
                        string s = textBox_Input1.Text;

                        if (s == "")
                            MessageBox.Show("Введите номер стартовой вершины!");
                        else
                        {
                            foreach (char c in s)
                                if ((int)c < 48 || (int)c > 58)
                                {
                                    flag = false;
                                    break;
                                }

                            if (flag)
                            {
                                if (Int32.Parse(s) - 1 < 0 || Int32.Parse(s) > vertex.Count)
                                    MessageBox.Show("Вершины с таким номером нет!");
                                else
                                {
                                    int StartIndex = Int32.Parse(s) - 1;
                                    textBox_Console.Text = "START: " + (StartIndex + 1).ToString() + '\r' + '\n';
                                    textBox_Console.Refresh();

                                    BFS(vertex[StartIndex]);
                                }
                            }
                            else
                                MessageBox.Show("Неверный формат ввода!" + '\r' + '\n' + "Можно использовать только символы от 0 до 9!");
                        }

                        break;
                    }

                case 4:
                    {
                        bool flag = true;
                        string s = textBox_Input1.Text;

                        if (s == "")
                            MessageBox.Show("Введите номер стартовой вершины!");
                        else
                        {
                            foreach (char c in s)
                                if ((int)c < 48 || (int)c > 58)
                                {
                                    flag = false;
                                    break;
                                }

                            if (flag)
                            {
                                if (Int32.Parse(s) - 1 < 0 || Int32.Parse(s) > vertex.Count)
                                    MessageBox.Show("Вершины с таким номером нет!");
                                else
                                {
                                    if (EulerTest())
                                    {
                                        int StartIndex = Int32.Parse(s) - 1;
                                        Search_Euler(vertex[StartIndex]);
                                    }
                                    else
                                        break;

                                    textBox_Console.Text = "START: " + s + '\r' + '\n';

                                    for (int i = 0; i < path.Count - 1; i++)
                                        textBox_Console.Text += path[i].number.ToString() + " -> ";
                                    textBox_Console.Text += path.Last().number.ToString();
                                }
                            }
                            else
                                MessageBox.Show("Неверный формат ввода!" + '\r' + '\n' + "Можно использовать только символы от 0 до 9!");
                        }

                        break;
                    }

                case 5:
                    {
                        bool flag1 = true, flag2 = true;
                        string start = textBox_Input1.Text, end = textBox_Input2.Text;

                        if (start == "" || end == "")
                            MessageBox.Show("Введите номера вершин!");
                        else
                        {
                            foreach (char c in start)
                                if ((int)c < 48 || (int)c > 58)
                                {
                                    flag1 = false;
                                    break;
                                }
                            foreach (char c in end)
                                if ((int)c < 48 || (int)c > 58)
                                {
                                    flag2 = false;
                                    break;
                                }

                            if (flag1 && flag2)
                            {
                                if (Int32.Parse(start) - 1 < 0 || Int32.Parse(start) > vertex.Count || Int32.Parse(end) - 1 < 0 || Int32.Parse(end) > vertex.Count)
                                    MessageBox.Show("Вершины с таким номером нет!");
                                else
                                    Dijkstra(vertex[Int32.Parse(start) - 1], vertex[Int32.Parse(end) - 1]);
                            }
                            else
                                MessageBox.Show("Неверный формат ввода!" + '\r' + '\n' + "Можно использовать только символы от 0 до 9!");
                        }

                        break;
                    }
            }

            domainUpDown_Algo.Enabled = true;
            checkedListBox_VertexForm.Enabled = true;
            trackBar_VertexSize.Enabled = true;
            checkBox_DarkTheme.Enabled = true;

            pictureBox1.Refresh();
        }

        private void domainUpDown_Algo_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (domainUpDown_Algo.SelectedIndex)
            {
                case 0:
                    {
                        textBox_Algo.Visible = false;
                        textBox_Manual.Visible = true;

                        textBox_Input1.Enabled = false;
                        textBox_Input2.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        textBox_Manual.Visible = false;
                        textBox_Algo.Visible = true;
                        textBox_Algo.Text = " Алгоритм Краскала — эффективный алгоритм построения минимального остовного дерева взвешенного связного неориентированного графа.";

                        textBox_Input1.Enabled = false;
                        textBox_Input2.Enabled = false;
                        break;
                    }

                case 2:
                    {
                        textBox_Manual.Visible = false;
                        textBox_Algo.Visible = true;
                        textBox_Algo.Text = " Поиск в глубину (англ. Depth-first search, DFS) — один из методов обхода графа. Стратегия поиска в глубину, как и следует из названия, состоит в том, чтобы идти «вглубь» графа, насколько это возможно.";

                        textBox_Input1.Enabled = true;
                        textBox_Input2.Enabled = false;
                        break;
                    }

                case 3:
                    {
                        textBox_Manual.Visible = false;
                        textBox_Algo.Visible = true;
                        textBox_Algo.Text = " Поиск в ширину(англ.Breadth - first search, BFS) — один из методов обхода графа. В результате поиска в ширину находится путь кратчайшей длины в невзвешенном графе, т.е. путь, содержащий наименьшее число рёбер.";

                        textBox_Input1.Enabled = true;
                        textBox_Input2.Enabled = false;
                        break;
                    }

                case 4:
                    {
                        textBox_Manual.Visible = false;
                        textBox_Algo.Visible = true;
                        textBox_Algo.Text = " Эйлеров цикл — замкнутый путь, проходящий через каждое ребро графа ровно по одному разу. Согласно теореме, доказанной Эйлером, эйлеров цикл существует тогда и только тогда, когда граф связный или будет являться связным, если удалить из него все изолированные вершины, и в нём отсутствуют вершины нечётной степени.";

                        textBox_Input1.Enabled = true;
                        textBox_Input2.Enabled = false;
                        break;
                    }

                case 5:
                    {
                        textBox_Manual.Visible = false;
                        textBox_Algo.Visible = true;
                        textBox_Algo.Text = " Алгоритм Дейкстры — алгоритм на графах, изобретённый нидерландским учёным Эдсгером Дейкстрой в 1959 году. Находит кратчайшие пути от одной из вершин графа до всех остальных. Алгоритм работает только для графов без рёбер отрицательного веса.";

                        textBox_Input1.Enabled = true;
                        textBox_Input2.Enabled = true;
                        break;
                    }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IND != -1)
                if (basket.IsCrossed(vertex[IND]))
                {
                    for (int j = 0; j < edge.Count; j++)
                        if (edge[j].IsVertex(vertex[IND]))
                        {
                            edge.Remove(edge[j]);
                            j--;
                        }

                    vertex.Remove(vertex[IND]);

                    for (int i = 0; i < vertex.Count(); i++)
                        vertex[i].number = i + 1;
                }

                    basket.visible = false;
            pictureBox1.Refresh();
        }
    }
}
