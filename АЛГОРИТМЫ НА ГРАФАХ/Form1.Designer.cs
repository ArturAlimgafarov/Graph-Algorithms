namespace АЛГОРИТМЫ_НА_ГРАФАХ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.checkedListBox_VertexForm = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_VertexSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Join = new System.Windows.Forms.Button();
            this.domainUpDown_Algo = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Input1 = new System.Windows.Forms.TextBox();
            this.textBox_Input2 = new System.Windows.Forms.TextBox();
            this.button_Run = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip_btJoin = new System.Windows.Forms.ToolTip(this.components);
            this.button_Delete = new System.Windows.Forms.Button();
            this.toolTip_btDelete = new System.Windows.Forms.ToolTip(this.components);
            this.button_Clear = new System.Windows.Forms.Button();
            this.toolTip_btClear = new System.Windows.Forms.ToolTip(this.components);
            this.button_ChangeWeight = new System.Windows.Forms.Button();
            this.toolTip_btChangeWeight = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_ChangeWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_DarkTheme = new System.Windows.Forms.CheckBox();
            this.toolTip_btRun = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_Manual = new System.Windows.Forms.TextBox();
            this.toolTip_PictureBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Console = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_Algo = new System.Windows.Forms.TextBox();
            this.checkBox_MoveOff = new System.Windows.Forms.CheckBox();
            this.checkBox_RandomWeights = new System.Windows.Forms.CheckBox();
            this.toolTip_RandomWeights = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_Basket = new System.Windows.Forms.PictureBox();
            this.pictureBox_OpenBasket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VertexSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OpenBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(284, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip_PictureBox.SetToolTip(this.pictureBox1, "Создавайте граф с помощью добавления вершин и ребер!");
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBox_Console
            // 
            this.textBox_Console.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Console.Location = new System.Drawing.Point(284, 455);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ReadOnly = true;
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Console.Size = new System.Drawing.Size(700, 106);
            this.textBox_Console.TabIndex = 1;
            this.toolTip_Console.SetToolTip(this.textBox_Console, "Окно для вывода результата работы алгоритма. Изменение содержимого запрещено!");
            // 
            // checkedListBox_VertexForm
            // 
            this.checkedListBox_VertexForm.BackColor = System.Drawing.Color.Silver;
            this.checkedListBox_VertexForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_VertexForm.CheckOnClick = true;
            this.checkedListBox_VertexForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox_VertexForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox_VertexForm.FormattingEnabled = true;
            this.checkedListBox_VertexForm.Items.AddRange(new object[] {
            "круглая",
            "квадратная"});
            this.checkedListBox_VertexForm.Location = new System.Drawing.Point(18, 77);
            this.checkedListBox_VertexForm.Name = "checkedListBox_VertexForm";
            this.checkedListBox_VertexForm.Size = new System.Drawing.Size(120, 32);
            this.checkedListBox_VertexForm.TabIndex = 2;
            this.checkedListBox_VertexForm.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxVertexForm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Форма вершин:";
            // 
            // trackBar_VertexSize
            // 
            this.trackBar_VertexSize.BackColor = System.Drawing.Color.Silver;
            this.trackBar_VertexSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_VertexSize.Location = new System.Drawing.Point(134, 76);
            this.trackBar_VertexSize.Maximum = 2;
            this.trackBar_VertexSize.Name = "trackBar_VertexSize";
            this.trackBar_VertexSize.Size = new System.Drawing.Size(132, 45);
            this.trackBar_VertexSize.TabIndex = 4;
            this.trackBar_VertexSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_VertexSize.Value = 1;
            this.trackBar_VertexSize.Scroll += new System.EventHandler(this.trackBar_VertexSize_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(144, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер вершин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "mid";
            // 
            // button_Join
            // 
            this.button_Join.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Join.Location = new System.Drawing.Point(28, 264);
            this.button_Join.Name = "button_Join";
            this.button_Join.Size = new System.Drawing.Size(95, 28);
            this.button_Join.TabIndex = 9;
            this.button_Join.Text = "Соединить";
            this.toolTip_btJoin.SetToolTip(this.button_Join, "(Клавиша \"J\")Выделите две вершины и нажмите на кнопку, чтобы создать ребро.\r\n");
            this.button_Join.UseVisualStyleBackColor = true;
            this.button_Join.Click += new System.EventHandler(this.button_Join_Click);
            // 
            // domainUpDown_Algo
            // 
            this.domainUpDown_Algo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.domainUpDown_Algo.Items.Add("Не выбрано");
            this.domainUpDown_Algo.Items.Add("Алгоритм Краскала");
            this.domainUpDown_Algo.Items.Add("Поиск в глубину");
            this.domainUpDown_Algo.Items.Add("Поиск в ширину");
            this.domainUpDown_Algo.Items.Add("Эйлеров цикл");
            this.domainUpDown_Algo.Items.Add("Алгоритм Дейкстры");
            this.domainUpDown_Algo.Location = new System.Drawing.Point(18, 27);
            this.domainUpDown_Algo.Name = "domainUpDown_Algo";
            this.domainUpDown_Algo.ReadOnly = true;
            this.domainUpDown_Algo.Size = new System.Drawing.Size(248, 20);
            this.domainUpDown_Algo.TabIndex = 10;
            this.domainUpDown_Algo.Text = "Не выбрано";
            this.domainUpDown_Algo.SelectedItemChanged += new System.EventHandler(this.domainUpDown_Algo_SelectedItemChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите алгоритм:";
            // 
            // textBox_Input1
            // 
            this.textBox_Input1.Enabled = false;
            this.textBox_Input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Input1.Location = new System.Drawing.Point(73, 468);
            this.textBox_Input1.Name = "textBox_Input1";
            this.textBox_Input1.Size = new System.Drawing.Size(45, 23);
            this.textBox_Input1.TabIndex = 12;
            this.textBox_Input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Input2
            // 
            this.textBox_Input2.Enabled = false;
            this.textBox_Input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Input2.Location = new System.Drawing.Point(223, 468);
            this.textBox_Input2.Name = "textBox_Input2";
            this.textBox_Input2.Size = new System.Drawing.Size(45, 23);
            this.textBox_Input2.TabIndex = 13;
            this.textBox_Input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Run
            // 
            this.button_Run.BackColor = System.Drawing.Color.Lime;
            this.button_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Run.Location = new System.Drawing.Point(32, 505);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(204, 44);
            this.button_Run.TabIndex = 14;
            this.button_Run.Text = "Выполнить";
            this.toolTip_btChangeWeight.SetToolTip(this.button_Run, "Введите номер стартовой и конечной вершин, если требуется, и нажмите \r\nна кнопку," +
        " чтобы запустить процесс выполнения выбранного алгоритма.\r\n ");
            this.button_Run.UseVisualStyleBackColor = false;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "START:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(158, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "FINISH:";
            // 
            // toolTip_btJoin
            // 
            this.toolTip_btJoin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_btJoin.ToolTipTitle = "Кнопка \"Соединить\"";
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.Location = new System.Drawing.Point(28, 301);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(95, 28);
            this.button_Delete.TabIndex = 17;
            this.button_Delete.Text = "Удалить";
            this.toolTip_btDelete.SetToolTip(this.button_Delete, "(Клавиша \"X\")Выделите вершину или ребро, а затем нажмите кнопку, чтобы удалить эл" +
        "емент.");
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // toolTip_btDelete
            // 
            this.toolTip_btDelete.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_btDelete.ToolTipTitle = "Кнопка \"Удалить\"";
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(146, 264);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(95, 28);
            this.button_Clear.TabIndex = 18;
            this.button_Clear.Text = "Очистить";
            this.toolTip_btClear.SetToolTip(this.button_Clear, "(Клавиша \"C\")Нажмите на кнопку, чтобы удалить все элементы с рабочего поля.");
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // toolTip_btClear
            // 
            this.toolTip_btClear.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_btClear.ToolTipTitle = "Кнопка \"Очистить\"";
            // 
            // button_ChangeWeight
            // 
            this.button_ChangeWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangeWeight.Location = new System.Drawing.Point(146, 301);
            this.button_ChangeWeight.Name = "button_ChangeWeight";
            this.button_ChangeWeight.Size = new System.Drawing.Size(95, 28);
            this.button_ChangeWeight.TabIndex = 19;
            this.button_ChangeWeight.Text = "Изменить";
            this.toolTip_btChangeWeight.SetToolTip(this.button_ChangeWeight, "Выделите одно ребро, введите в поле вес ребра и нажмите на кнопку или\r\nклавишу En" +
        "ter.\r\nФормат ввода: целое число без знака, если 0, ребро не имеет веса.");
            this.button_ChangeWeight.UseVisualStyleBackColor = true;
            this.button_ChangeWeight.Click += new System.EventHandler(this.button_ChangeWeight_Click);
            // 
            // toolTip_btChangeWeight
            // 
            this.toolTip_btChangeWeight.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_btChangeWeight.ToolTipTitle = "Кнопка \"Изменить\"";
            // 
            // textBox_ChangeWeight
            // 
            this.textBox_ChangeWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ChangeWeight.Location = new System.Drawing.Point(146, 338);
            this.textBox_ChangeWeight.Name = "textBox_ChangeWeight";
            this.textBox_ChangeWeight.Size = new System.Drawing.Size(95, 23);
            this.textBox_ChangeWeight.TabIndex = 20;
            this.textBox_ChangeWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Введите вес:";
            // 
            // checkBox_DarkTheme
            // 
            this.checkBox_DarkTheme.AutoSize = true;
            this.checkBox_DarkTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_DarkTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_DarkTheme.Location = new System.Drawing.Point(18, 400);
            this.checkBox_DarkTheme.Name = "checkBox_DarkTheme";
            this.checkBox_DarkTheme.Size = new System.Drawing.Size(124, 21);
            this.checkBox_DarkTheme.TabIndex = 22;
            this.checkBox_DarkTheme.Text = "Тёмная тема";
            this.checkBox_DarkTheme.UseVisualStyleBackColor = true;
            this.checkBox_DarkTheme.CheckedChanged += new System.EventHandler(this.checkBox_DarkTheme_CheckedChanged);
            // 
            // toolTip_btRun
            // 
            this.toolTip_btRun.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_btRun.ToolTipTitle = "Кнопка \"Выполнить\"";
            // 
            // textBox_Manual
            // 
            this.textBox_Manual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Manual.Location = new System.Drawing.Point(18, 115);
            this.textBox_Manual.Multiline = true;
            this.textBox_Manual.Name = "textBox_Manual";
            this.textBox_Manual.ReadOnly = true;
            this.textBox_Manual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Manual.Size = new System.Drawing.Size(233, 139);
            this.textBox_Manual.TabIndex = 23;
            this.textBox_Manual.Text = resources.GetString("textBox_Manual.Text");
            // 
            // toolTip_PictureBox
            // 
            this.toolTip_PictureBox.ToolTipTitle = "\"Рабочее поле\"";
            // 
            // toolTip_Console
            // 
            this.toolTip_Console.ToolTipTitle = "\"Консоль\"";
            // 
            // textBox_Algo
            // 
            this.textBox_Algo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Algo.Location = new System.Drawing.Point(18, 131);
            this.textBox_Algo.Multiline = true;
            this.textBox_Algo.Name = "textBox_Algo";
            this.textBox_Algo.ReadOnly = true;
            this.textBox_Algo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Algo.Size = new System.Drawing.Size(233, 123);
            this.textBox_Algo.TabIndex = 25;
            this.textBox_Algo.Visible = false;
            // 
            // checkBox_MoveOff
            // 
            this.checkBox_MoveOff.AutoSize = true;
            this.checkBox_MoveOff.Checked = true;
            this.checkBox_MoveOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MoveOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_MoveOff.Location = new System.Drawing.Point(18, 427);
            this.checkBox_MoveOff.Name = "checkBox_MoveOff";
            this.checkBox_MoveOff.Size = new System.Drawing.Size(132, 21);
            this.checkBox_MoveOff.TabIndex = 26;
            this.checkBox_MoveOff.Text = "Перемещение";
            this.checkBox_MoveOff.UseVisualStyleBackColor = true;
            // 
            // checkBox_RandomWeights
            // 
            this.checkBox_RandomWeights.AutoSize = true;
            this.checkBox_RandomWeights.Checked = true;
            this.checkBox_RandomWeights.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RandomWeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_RandomWeights.Location = new System.Drawing.Point(18, 373);
            this.checkBox_RandomWeights.Name = "checkBox_RandomWeights";
            this.checkBox_RandomWeights.Size = new System.Drawing.Size(140, 21);
            this.checkBox_RandomWeights.TabIndex = 27;
            this.checkBox_RandomWeights.Text = "Случайный вес";
            this.toolTip_RandomWeights.SetToolTip(this.checkBox_RandomWeights, "Задает случайный вес при добавлении ребра.");
            this.checkBox_RandomWeights.UseVisualStyleBackColor = true;
            // 
            // toolTip_RandomWeights
            // 
            this.toolTip_RandomWeights.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_RandomWeights.ToolTipTitle = "Клавиша \"R\"";
            // 
            // pictureBox_Basket
            // 
            this.pictureBox_Basket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Basket.Image")));
            this.pictureBox_Basket.Location = new System.Drawing.Point(292, 8);
            this.pictureBox_Basket.Name = "pictureBox_Basket";
            this.pictureBox_Basket.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Basket.TabIndex = 28;
            this.pictureBox_Basket.TabStop = false;
            this.pictureBox_Basket.Visible = false;
            // 
            // pictureBox_OpenBasket
            // 
            this.pictureBox_OpenBasket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OpenBasket.Image")));
            this.pictureBox_OpenBasket.Location = new System.Drawing.Point(348, 7);
            this.pictureBox_OpenBasket.Name = "pictureBox_OpenBasket";
            this.pictureBox_OpenBasket.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_OpenBasket.TabIndex = 29;
            this.pictureBox_OpenBasket.TabStop = false;
            this.pictureBox_OpenBasket.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_OpenBasket);
            this.Controls.Add(this.checkBox_RandomWeights);
            this.Controls.Add(this.checkBox_MoveOff);
            this.Controls.Add(this.textBox_Manual);
            this.Controls.Add(this.checkBox_DarkTheme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_ChangeWeight);
            this.Controls.Add(this.button_ChangeWeight);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBox_Input2);
            this.Controls.Add(this.textBox_Input1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.domainUpDown_Algo);
            this.Controls.Add(this.button_Join);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_VertexSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox_VertexForm);
            this.Controls.Add(this.textBox_Console);
            this.Controls.Add(this.textBox_Algo);
            this.Controls.Add(this.pictureBox_Basket);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Алгоритмы на графах";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VertexSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OpenBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.CheckedListBox checkedListBox_VertexForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_VertexSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Join;
        private System.Windows.Forms.DomainUpDown domainUpDown_Algo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Input1;
        private System.Windows.Forms.TextBox textBox_Input2;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip_btJoin;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ToolTip toolTip_btDelete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ToolTip toolTip_btClear;
        private System.Windows.Forms.Button button_ChangeWeight;
        private System.Windows.Forms.ToolTip toolTip_btChangeWeight;
        private System.Windows.Forms.TextBox textBox_ChangeWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_DarkTheme;
        private System.Windows.Forms.ToolTip toolTip_btRun;
        private System.Windows.Forms.TextBox textBox_Manual;
        private System.Windows.Forms.ToolTip toolTip_PictureBox;
        private System.Windows.Forms.ToolTip toolTip_Console;
        private System.Windows.Forms.TextBox textBox_Algo;
        private System.Windows.Forms.CheckBox checkBox_MoveOff;
        private System.Windows.Forms.CheckBox checkBox_RandomWeights;
        private System.Windows.Forms.ToolTip toolTip_RandomWeights;
        private System.Windows.Forms.PictureBox pictureBox_Basket;
        private System.Windows.Forms.PictureBox pictureBox_OpenBasket;
    }
}

