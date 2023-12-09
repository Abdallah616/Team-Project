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
            NameButton = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            SHEET = new Button();
            panel1 = new Panel();
            No_Of_HoursButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            RateButton = new Button();
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
            listBox3.Location = new Point(0, 421);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(201, 49);
            listBox3.TabIndex = 0;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.ForeColor = SystemColors.ControlText;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 250);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(201, 49);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = SystemColors.InfoText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 49);
            listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(NameButton);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel3.Location = new Point(22, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 131);
            panel3.TabIndex = 0;
            // 
            // NameButton
            // 
            NameButton.BackColor = Color.SandyBrown;
            NameButton.BackgroundImageLayout = ImageLayout.Zoom;
            NameButton.Cursor = Cursors.Hand;
            NameButton.FlatAppearance.BorderSize = 0;
            NameButton.FlatStyle = FlatStyle.Popup;
            NameButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            NameButton.ForeColor = SystemColors.ControlText;
            NameButton.Location = new Point(471, 52);
            NameButton.Name = "NameButton";
            NameButton.Size = new Size(125, 40);
            NameButton.TabIndex = 3;
            NameButton.Text = "INPUT DATA";
            NameButton.UseVisualStyleBackColor = false;
            //NameButton.Click += button1_Click;
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
            textBox2.TextChanged += textBox2_TextChanged;
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
            label2.Size = new Size(113, 37);
            label2.TabIndex = 0;
            label2.Text = "Name";
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
            SHEET.Click += SHEET_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(No_Of_HoursButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(22, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 131);
            panel1.TabIndex = 0;
            // 
            // No_Of_HoursButton
            // 
            No_Of_HoursButton.BackColor = Color.SandyBrown;
            No_Of_HoursButton.BackgroundImageLayout = ImageLayout.Zoom;
            No_Of_HoursButton.Cursor = Cursors.Hand;
            No_Of_HoursButton.FlatAppearance.BorderSize = 0;
            No_Of_HoursButton.FlatStyle = FlatStyle.Popup;
            No_Of_HoursButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            No_Of_HoursButton.ForeColor = SystemColors.ControlText;
            No_Of_HoursButton.Location = new Point(471, 52);
            No_Of_HoursButton.Name = "No_Of_HoursButton";
            No_Of_HoursButton.Size = new Size(125, 40);
            No_Of_HoursButton.TabIndex = 3;
            No_Of_HoursButton.Text = "INPUT DATA";
            No_Of_HoursButton.UseVisualStyleBackColor = false;
            No_Of_HoursButton.Click += new EventHandler(button3_Click);
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
            label1.Size = new Size(118, 37);
            label1.TabIndex = 0;
            label1.Text = "Hours";
            label1.Click += label1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(RateButton);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label3);
            panel4.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel4.Location = new Point(22, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(625, 131);
            panel4.TabIndex = 0;
            // 
            // RateButton
            // 
            RateButton.BackColor = Color.SandyBrown;
            RateButton.BackgroundImageLayout = ImageLayout.Zoom;
            RateButton.Cursor = Cursors.Hand;
            RateButton.FlatAppearance.BorderSize = 0;
            RateButton.FlatStyle = FlatStyle.Popup;
            RateButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            RateButton.ForeColor = SystemColors.ControlText;
            RateButton.Location = new Point(471, 52);
            RateButton.Name = "RateButton";
            RateButton.Size = new Size(125, 40);
            RateButton.TabIndex = 3;
            RateButton.Text = "INPUT DATA";
            RateButton.UseVisualStyleBackColor = false;
            RateButton.Click += new EventHandler(SalaryButton_Click);
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
            label3.Size = new Size(92, 37);
            label3.TabIndex = 0;
            label3.Text = "Rate";
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
        public System.Windows.Forms.Button NameButton;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button SHEET;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button No_Of_HoursButton;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button RateButton;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label3;
    }
}