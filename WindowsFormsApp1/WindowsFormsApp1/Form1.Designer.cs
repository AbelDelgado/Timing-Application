namespace WindowsFormsApp1
{
    partial class AthleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lane1 = new System.Windows.Forms.TextBox();
            this.country1 = new System.Windows.Forms.ListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.country2 = new System.Windows.Forms.ListBox();
            this.lane2 = new System.Windows.Forms.TextBox();
            this.country3 = new System.Windows.Forms.ListBox();
            this.lane3 = new System.Windows.Forms.TextBox();
            this.country4 = new System.Windows.Forms.ListBox();
            this.lane4 = new System.Windows.Forms.TextBox();
            this.country5 = new System.Windows.Forms.ListBox();
            this.lane5 = new System.Windows.Forms.TextBox();
            this.country6 = new System.Windows.Forms.ListBox();
            this.lane6 = new System.Windows.Forms.TextBox();
            this.country7 = new System.Windows.Forms.ListBox();
            this.lane7 = new System.Windows.Forms.TextBox();
            this.country8 = new System.Windows.Forms.ListBox();
            this.lane8 = new System.Windows.Forms.TextBox();
            this.country9 = new System.Windows.Forms.ListBox();
            this.lane9 = new System.Windows.Forms.TextBox();
            this.country10 = new System.Windows.Forms.ListBox();
            this.lane10 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.MilisecondsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.standing10 = new System.Windows.Forms.Label();
            this.standing9 = new System.Windows.Forms.Label();
            this.standing8 = new System.Windows.Forms.Label();
            this.standing7 = new System.Windows.Forms.Label();
            this.standing6 = new System.Windows.Forms.Label();
            this.standing5 = new System.Windows.Forms.Label();
            this.standing4 = new System.Windows.Forms.Label();
            this.standing3 = new System.Windows.Forms.Label();
            this.standing2 = new System.Windows.Forms.Label();
            this.standing1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(76, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // lane1
            // 
            this.lane1.Location = new System.Drawing.Point(6, 60);
            this.lane1.Name = "lane1";
            this.lane1.Size = new System.Drawing.Size(100, 20);
            this.lane1.TabIndex = 1;
            // 
            // country1
            // 
            this.country1.FormattingEnabled = true;
            this.country1.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country1.Location = new System.Drawing.Point(112, 60);
            this.country1.Name = "country1";
            this.country1.Size = new System.Drawing.Size(120, 30);
            this.country1.TabIndex = 2;
            this.country1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // country2
            // 
            this.country2.FormattingEnabled = true;
            this.country2.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country2.Location = new System.Drawing.Point(112, 96);
            this.country2.Name = "country2";
            this.country2.Size = new System.Drawing.Size(120, 30);
            this.country2.TabIndex = 5;
            this.country2.Visible = false;
            // 
            // lane2
            // 
            this.lane2.Location = new System.Drawing.Point(6, 96);
            this.lane2.Name = "lane2";
            this.lane2.Size = new System.Drawing.Size(100, 20);
            this.lane2.TabIndex = 4;
            // 
            // country3
            // 
            this.country3.FormattingEnabled = true;
            this.country3.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country3.Location = new System.Drawing.Point(112, 132);
            this.country3.Name = "country3";
            this.country3.Size = new System.Drawing.Size(120, 30);
            this.country3.TabIndex = 8;
            this.country3.Visible = false;
            // 
            // lane3
            // 
            this.lane3.Location = new System.Drawing.Point(6, 132);
            this.lane3.Name = "lane3";
            this.lane3.Size = new System.Drawing.Size(100, 20);
            this.lane3.TabIndex = 7;
            // 
            // country4
            // 
            this.country4.FormattingEnabled = true;
            this.country4.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country4.Location = new System.Drawing.Point(112, 168);
            this.country4.Name = "country4";
            this.country4.Size = new System.Drawing.Size(120, 30);
            this.country4.TabIndex = 11;
            this.country4.Visible = false;
            // 
            // lane4
            // 
            this.lane4.Location = new System.Drawing.Point(6, 168);
            this.lane4.Name = "lane4";
            this.lane4.Size = new System.Drawing.Size(100, 20);
            this.lane4.TabIndex = 10;
            // 
            // country5
            // 
            this.country5.FormattingEnabled = true;
            this.country5.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country5.Location = new System.Drawing.Point(112, 204);
            this.country5.Name = "country5";
            this.country5.Size = new System.Drawing.Size(120, 30);
            this.country5.TabIndex = 13;
            this.country5.Visible = false;
            // 
            // lane5
            // 
            this.lane5.Location = new System.Drawing.Point(6, 204);
            this.lane5.Name = "lane5";
            this.lane5.Size = new System.Drawing.Size(100, 20);
            this.lane5.TabIndex = 12;
            // 
            // country6
            // 
            this.country6.FormattingEnabled = true;
            this.country6.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country6.Location = new System.Drawing.Point(371, 60);
            this.country6.Name = "country6";
            this.country6.Size = new System.Drawing.Size(120, 30);
            this.country6.TabIndex = 15;
            this.country6.Visible = false;
            // 
            // lane6
            // 
            this.lane6.Location = new System.Drawing.Point(265, 60);
            this.lane6.Name = "lane6";
            this.lane6.Size = new System.Drawing.Size(100, 20);
            this.lane6.TabIndex = 14;
            // 
            // country7
            // 
            this.country7.FormattingEnabled = true;
            this.country7.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country7.Location = new System.Drawing.Point(371, 96);
            this.country7.Name = "country7";
            this.country7.Size = new System.Drawing.Size(120, 30);
            this.country7.TabIndex = 17;
            this.country7.Visible = false;
            // 
            // lane7
            // 
            this.lane7.Location = new System.Drawing.Point(265, 96);
            this.lane7.Name = "lane7";
            this.lane7.Size = new System.Drawing.Size(100, 20);
            this.lane7.TabIndex = 16;
            // 
            // country8
            // 
            this.country8.FormattingEnabled = true;
            this.country8.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country8.Location = new System.Drawing.Point(371, 132);
            this.country8.Name = "country8";
            this.country8.Size = new System.Drawing.Size(120, 30);
            this.country8.TabIndex = 19;
            this.country8.Visible = false;
            // 
            // lane8
            // 
            this.lane8.Location = new System.Drawing.Point(265, 132);
            this.lane8.Name = "lane8";
            this.lane8.Size = new System.Drawing.Size(100, 20);
            this.lane8.TabIndex = 18;
            // 
            // country9
            // 
            this.country9.FormattingEnabled = true;
            this.country9.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country9.Location = new System.Drawing.Point(371, 168);
            this.country9.Name = "country9";
            this.country9.Size = new System.Drawing.Size(120, 30);
            this.country9.TabIndex = 21;
            this.country9.Visible = false;
            // 
            // lane9
            // 
            this.lane9.Location = new System.Drawing.Point(265, 168);
            this.lane9.Name = "lane9";
            this.lane9.Size = new System.Drawing.Size(100, 20);
            this.lane9.TabIndex = 20;
            // 
            // country10
            // 
            this.country10.FormattingEnabled = true;
            this.country10.Items.AddRange(new object[] {
            "Canada",
            "United States",
            "England",
            "Mexico"});
            this.country10.Location = new System.Drawing.Point(371, 204);
            this.country10.Name = "country10";
            this.country10.Size = new System.Drawing.Size(120, 30);
            this.country10.TabIndex = 23;
            this.country10.Visible = false;
            // 
            // lane10
            // 
            this.lane10.Location = new System.Drawing.Point(265, 204);
            this.lane10.Name = "lane10";
            this.lane10.Size = new System.Drawing.Size(100, 20);
            this.lane10.TabIndex = 22;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(150, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 36;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(187, 15);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 35;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(221, 15);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 37;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(258, 15);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 42;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(295, 15);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(31, 17);
            this.radioButton7.TabIndex = 41;
            this.radioButton7.Text = "7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(332, 15);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(31, 17);
            this.radioButton8.TabIndex = 40;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(369, 15);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(31, 17);
            this.radioButton9.TabIndex = 39;
            this.radioButton9.Text = "9";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(406, 15);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(37, 17);
            this.radioButton10.TabIndex = 38;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.makeLaneAppear);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 300);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lane1);
            this.tabPage1.Controls.Add(this.radioButton6);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.radioButton7);
            this.tabPage1.Controls.Add(this.country1);
            this.tabPage1.Controls.Add(this.radioButton8);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton9);
            this.tabPage1.Controls.Add(this.lane2);
            this.tabPage1.Controls.Add(this.radioButton10);
            this.tabPage1.Controls.Add(this.country2);
            this.tabPage1.Controls.Add(this.radioButton5);
            this.tabPage1.Controls.Add(this.lane3);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.country3);
            this.tabPage1.Controls.Add(this.radioButton4);
            this.tabPage1.Controls.Add(this.lane4);
            this.tabPage1.Controls.Add(this.country10);
            this.tabPage1.Controls.Add(this.country4);
            this.tabPage1.Controls.Add(this.lane10);
            this.tabPage1.Controls.Add(this.lane5);
            this.tabPage1.Controls.Add(this.country9);
            this.tabPage1.Controls.Add(this.country5);
            this.tabPage1.Controls.Add(this.lane9);
            this.tabPage1.Controls.Add(this.lane6);
            this.tabPage1.Controls.Add(this.country8);
            this.tabPage1.Controls.Add(this.country6);
            this.tabPage1.Controls.Add(this.lane8);
            this.tabPage1.Controls.Add(this.lane7);
            this.tabPage1.Controls.Add(this.country7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Athletes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.MinutesLabel);
            this.tabPage2.Controls.Add(this.SecondsLabel);
            this.tabPage2.Controls.Add(this.MilisecondsLabel);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Race";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "minutes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(371, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 199);
            this.listBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "seconds";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesLabel.Location = new System.Drawing.Point(16, 21);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(68, 73);
            this.MinutesLabel.TabIndex = 4;
            this.MinutesLabel.Text = "0";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.Location = new System.Drawing.Point(136, 21);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(68, 73);
            this.SecondsLabel.TabIndex = 3;
            this.SecondsLabel.Text = "0";
            // 
            // MilisecondsLabel
            // 
            this.MilisecondsLabel.AutoSize = true;
            this.MilisecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilisecondsLabel.Location = new System.Drawing.Point(261, 21);
            this.MilisecondsLabel.Name = "MilisecondsLabel";
            this.MilisecondsLabel.Size = new System.Drawing.Size(68, 73);
            this.MilisecondsLabel.TabIndex = 2;
            this.MilisecondsLabel.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(248, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.standing10);
            this.tabPage3.Controls.Add(this.standing9);
            this.tabPage3.Controls.Add(this.standing8);
            this.tabPage3.Controls.Add(this.standing7);
            this.tabPage3.Controls.Add(this.standing6);
            this.tabPage3.Controls.Add(this.standing5);
            this.tabPage3.Controls.Add(this.standing4);
            this.tabPage3.Controls.Add(this.standing3);
            this.tabPage3.Controls.Add(this.standing2);
            this.tabPage3.Controls.Add(this.standing1);
            this.tabPage3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(519, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Standings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(413, 196);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 29);
            this.textBox10.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(278, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 29);
            this.textBox9.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(149, 196);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 29);
            this.textBox8.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 196);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 29);
            this.textBox7.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(364, 130);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 29);
            this.textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(209, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 10;
            // 
            // standing10
            // 
            this.standing10.AutoSize = true;
            this.standing10.Location = new System.Drawing.Point(464, 235);
            this.standing10.Name = "standing10";
            this.standing10.Size = new System.Drawing.Size(0, 22);
            this.standing10.TabIndex = 9;
            // 
            // standing9
            // 
            this.standing9.AutoSize = true;
            this.standing9.Location = new System.Drawing.Point(355, 235);
            this.standing9.Name = "standing9";
            this.standing9.Size = new System.Drawing.Size(0, 22);
            this.standing9.TabIndex = 8;
            // 
            // standing8
            // 
            this.standing8.AutoSize = true;
            this.standing8.Location = new System.Drawing.Point(227, 235);
            this.standing8.Name = "standing8";
            this.standing8.Size = new System.Drawing.Size(0, 22);
            this.standing8.TabIndex = 7;
            // 
            // standing7
            // 
            this.standing7.AutoSize = true;
            this.standing7.Location = new System.Drawing.Point(95, 235);
            this.standing7.Name = "standing7";
            this.standing7.Size = new System.Drawing.Size(0, 22);
            this.standing7.TabIndex = 6;
            // 
            // standing6
            // 
            this.standing6.AutoSize = true;
            this.standing6.Location = new System.Drawing.Point(464, 161);
            this.standing6.Name = "standing6";
            this.standing6.Size = new System.Drawing.Size(0, 22);
            this.standing6.TabIndex = 5;
            // 
            // standing5
            // 
            this.standing5.AutoSize = true;
            this.standing5.Location = new System.Drawing.Point(271, 161);
            this.standing5.Name = "standing5";
            this.standing5.Size = new System.Drawing.Size(0, 22);
            this.standing5.TabIndex = 4;
            // 
            // standing4
            // 
            this.standing4.AutoSize = true;
            this.standing4.Location = new System.Drawing.Point(95, 161);
            this.standing4.Name = "standing4";
            this.standing4.Size = new System.Drawing.Size(0, 22);
            this.standing4.TabIndex = 3;
            // 
            // standing3
            // 
            this.standing3.AutoSize = true;
            this.standing3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standing3.Location = new System.Drawing.Point(255, 77);
            this.standing3.Name = "standing3";
            this.standing3.Size = new System.Drawing.Size(0, 33);
            this.standing3.TabIndex = 2;
            // 
            // standing2
            // 
            this.standing2.AutoSize = true;
            this.standing2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standing2.Location = new System.Drawing.Point(272, 42);
            this.standing2.Name = "standing2";
            this.standing2.Size = new System.Drawing.Size(0, 33);
            this.standing2.TabIndex = 1;
            // 
            // standing1
            // 
            this.standing1.AutoSize = true;
            this.standing1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standing1.Location = new System.Drawing.Point(272, 14);
            this.standing1.Name = "standing1";
            this.standing1.Size = new System.Drawing.Size(0, 33);
            this.standing1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // AthleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 338);
            this.Controls.Add(this.tabControl1);
            this.Name = "AthleteForm";
            this.Text = "Abel Delgado";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox lane1;
        private System.Windows.Forms.ListBox country1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox country2;
        private System.Windows.Forms.TextBox lane2;
        private System.Windows.Forms.ListBox country3;
        private System.Windows.Forms.TextBox lane3;
        private System.Windows.Forms.ListBox country4;
        private System.Windows.Forms.TextBox lane4;
        private System.Windows.Forms.ListBox country5;
        private System.Windows.Forms.TextBox lane5;
        private System.Windows.Forms.ListBox country6;
        private System.Windows.Forms.TextBox lane6;
        private System.Windows.Forms.ListBox country7;
        private System.Windows.Forms.TextBox lane7;
        private System.Windows.Forms.ListBox country8;
        private System.Windows.Forms.TextBox lane8;
        private System.Windows.Forms.ListBox country9;
        private System.Windows.Forms.TextBox lane9;
        private System.Windows.Forms.ListBox country10;
        private System.Windows.Forms.TextBox lane10;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MilisecondsLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label standing10;
        private System.Windows.Forms.Label standing9;
        private System.Windows.Forms.Label standing8;
        private System.Windows.Forms.Label standing7;
        private System.Windows.Forms.Label standing6;
        private System.Windows.Forms.Label standing5;
        private System.Windows.Forms.Label standing4;
        private System.Windows.Forms.Label standing3;
        private System.Windows.Forms.Label standing2;
        private System.Windows.Forms.Label standing1;
    }
}

