namespace Team_Project
{
    partial class Form1
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
            panel2 = new Panel();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            panel3 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            SHEET = new Button();
            panel1 = new Panel();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            button4 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(686, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 542);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.White;
            listBox3.ForeColor = SystemColors.ControlText;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(0, 391);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(204, 109);
            listBox3.TabIndex = 0;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.ForeColor = SystemColors.ControlText;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 218);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(201, 109);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = SystemColors.InfoText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 94);
            listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel3.Location = new Point(22, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 131);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(471, 52);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 3;
            button2.Text = "INPUT DATA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(150, 50);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 39);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 0;
            label2.Text = "LAB1\r\n";
            label2.Click += label1_Click_1;
            // 
            // SHEET
            // 
            SHEET.BackColor = Color.Indigo;
            SHEET.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SHEET.ForeColor = Color.White;
            SHEET.Location = new Point(359, 622);
            SHEET.Name = "SHEET";
            SHEET.Size = new Size(210, 61);
            SHEET.TabIndex = 2;
            SHEET.Text = "GO TO THE SHEET";
            SHEET.UseVisualStyleBackColor = false;
            SHEET.Click += new EventHandler(SHEET_Click_1);
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(22, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 131);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(471, 52);
            button3.Name = "button3";
            button3.Size = new Size(125, 40);
            button3.TabIndex = 3;
            button3.Text = "INPUT DATA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(150, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 39);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(17, 50);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 0;
            label1.Text = "LAB1\r\n";
            label1.Click += label1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label3);
            panel4.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel4.Location = new Point(22, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(625, 131);
            panel4.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.SandyBrown;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(471, 52);
            button4.Name = "button4";
            button4.Size = new Size(125, 40);
            button4.TabIndex = 3;
            button4.Text = "INPUT DATA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(150, 50);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 39);
            textBox3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(17, 50);
            label3.Name = "label3";
            label3.Size = new Size(102, 37);
            label3.TabIndex = 0;
            label3.Text = "LAB1\r\n";
            label3.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_08_at_21_12_35_0ff9bb80;
            ClientSize = new Size(913, 727);
            Controls.Add(SHEET);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(150, 50);
            Name = "Form1";
            Text = "SALARY ";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox3;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button SHEET;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label3;
    }
}