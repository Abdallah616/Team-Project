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
            panel3 = new Panel();
            tx_name = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            tx_hour = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            tx_rate = new TextBox();
            label3 = new Label();
            tx_days = new TextBox();
            label4 = new Label();
            OpenFile_bt = new Button();
            ReadFromFile_bt = new Button();
            InsertToFile_bt = new Button();
            Clear_bt = new Button();
            StartOfFile_bt = new Button();
            EndOfFile_bt = new Button();
            textBox1 = new TextBox();
            LoadIndex_bt = new Button();
            tx_Id = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            Exit_bt = new Button();
            SHEET = new Button();
            search_bt = new Button();
            delete_bt = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(tx_name);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel3.Location = new Point(20, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 80);
            panel3.TabIndex = 6;
            // 
            // tx_name
            // 
            tx_name.BackColor = Color.White;
            tx_name.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_name.Location = new Point(147, 24);
            tx_name.Multiline = true;
            tx_name.Name = "tx_name";
            tx_name.Size = new Size(260, 30);
            tx_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(113, 37);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tx_hour);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(20, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 80);
            panel1.TabIndex = 5;
            // 
            // tx_hour
            // 
            tx_hour.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_hour.Location = new Point(150, 22);
            tx_hour.Multiline = true;
            tx_hour.Name = "tx_hour";
            tx_hour.Size = new Size(260, 30);
            tx_hour.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 37);
            label1.TabIndex = 2;
            label1.Text = "Hours";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(tx_rate);
            panel4.Controls.Add(label3);
            panel4.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel4.Location = new Point(20, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 80);
            panel4.TabIndex = 4;
            // 
            // tx_rate
            // 
            tx_rate.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_rate.Location = new Point(147, 27);
            tx_rate.Multiline = true;
            tx_rate.Name = "tx_rate";
            tx_rate.Size = new Size(260, 30);
            tx_rate.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 37);
            label3.TabIndex = 2;
            label3.Text = "Rate";
            // 
            // tx_days
            // 
            tx_days.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_days.Location = new Point(190, 396);
            tx_days.Name = "tx_days";
            tx_days.Size = new Size(240, 40);
            tx_days.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(20, 402);
            label4.Name = "label4";
            label4.Size = new Size(160, 27);
            label4.TabIndex = 0;
            label4.Text = "Days Works";
            // 
            // OpenFile_bt
            // 
            OpenFile_bt.BackColor = Color.Indigo;
            OpenFile_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OpenFile_bt.ForeColor = Color.White;
            OpenFile_bt.Location = new Point(14, 468);
            OpenFile_bt.Name = "OpenFile_bt";
            OpenFile_bt.Size = new Size(115, 60);
            OpenFile_bt.TabIndex = 7;
            OpenFile_bt.Text = "Open File";
            OpenFile_bt.UseVisualStyleBackColor = false;
            OpenFile_bt.Click += OpenFile_bt_Click;
            // 
            // ReadFromFile_bt
            // 
            ReadFromFile_bt.BackColor = Color.Indigo;
            ReadFromFile_bt.Enabled = false;
            ReadFromFile_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ReadFromFile_bt.ForeColor = Color.White;
            ReadFromFile_bt.Location = new Point(138, 468);
            ReadFromFile_bt.Name = "ReadFromFile_bt";
            ReadFromFile_bt.Size = new Size(115, 60);
            ReadFromFile_bt.TabIndex = 8;
            ReadFromFile_bt.Text = "Read From File";
            ReadFromFile_bt.UseVisualStyleBackColor = false;
            ReadFromFile_bt.Click += ReadFromFile_bt_Click;
            // 
            // InsertToFile_bt
            // 
            InsertToFile_bt.BackColor = Color.Indigo;
            InsertToFile_bt.Enabled = false;
            InsertToFile_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            InsertToFile_bt.ForeColor = Color.White;
            InsertToFile_bt.Location = new Point(259, 468);
            InsertToFile_bt.Name = "InsertToFile_bt";
            InsertToFile_bt.Size = new Size(115, 60);
            InsertToFile_bt.TabIndex = 9;
            InsertToFile_bt.Text = "Insert To File";
            InsertToFile_bt.UseVisualStyleBackColor = false;
            InsertToFile_bt.Click += InsertToFile_bt_Click;
            // 
            // Clear_bt
            // 
            Clear_bt.BackColor = Color.Indigo;
            Clear_bt.Enabled = false;
            Clear_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Clear_bt.ForeColor = Color.White;
            Clear_bt.Location = new Point(259, 545);
            Clear_bt.Name = "Clear_bt";
            Clear_bt.Size = new Size(115, 60);
            Clear_bt.TabIndex = 10;
            Clear_bt.Text = "Clear";
            Clear_bt.UseVisualStyleBackColor = false;
            Clear_bt.Click += Clear_bt_Click;
            // 
            // StartOfFile_bt
            // 
            StartOfFile_bt.BackColor = Color.Indigo;
            StartOfFile_bt.Enabled = false;
            StartOfFile_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            StartOfFile_bt.ForeColor = Color.White;
            StartOfFile_bt.Location = new Point(380, 468);
            StartOfFile_bt.Name = "StartOfFile_bt";
            StartOfFile_bt.Size = new Size(115, 60);
            StartOfFile_bt.TabIndex = 11;
            StartOfFile_bt.Text = "Start Of File";
            StartOfFile_bt.UseVisualStyleBackColor = false;
            StartOfFile_bt.Click += StartOfFile_bt_Click;
            // 
            // EndOfFile_bt
            // 
            EndOfFile_bt.BackColor = Color.Indigo;
            EndOfFile_bt.Enabled = false;
            EndOfFile_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EndOfFile_bt.ForeColor = Color.White;
            EndOfFile_bt.Location = new Point(380, 545);
            EndOfFile_bt.Name = "EndOfFile_bt";
            EndOfFile_bt.Size = new Size(115, 60);
            EndOfFile_bt.TabIndex = 12;
            EndOfFile_bt.Text = "End Of File";
            EndOfFile_bt.UseVisualStyleBackColor = false;
            EndOfFile_bt.Click += EndOfFile_bt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 401);
            textBox1.TabIndex = 13;
            // 
            // LoadIndex_bt
            // 
            LoadIndex_bt.BackColor = Color.Indigo;
            LoadIndex_bt.Enabled = false;
            LoadIndex_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoadIndex_bt.ForeColor = Color.White;
            LoadIndex_bt.Location = new Point(14, 545);
            LoadIndex_bt.Name = "LoadIndex_bt";
            LoadIndex_bt.Size = new Size(115, 60);
            LoadIndex_bt.TabIndex = 14;
            LoadIndex_bt.Text = "Load Index";
            LoadIndex_bt.UseVisualStyleBackColor = false;
            LoadIndex_bt.Click += LoadIndex_bt_Click;
            // 
            // tx_Id
            // 
            tx_Id.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_Id.Location = new Point(147, 22);
            tx_Id.Multiline = true;
            tx_Id.Name = "tx_Id";
            tx_Id.Size = new Size(260, 30);
            tx_Id.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(29, 22);
            label5.Name = "label5";
            label5.Size = new Size(50, 37);
            label5.TabIndex = 4;
            label5.Text = "Id";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Enabled = false;
            button1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(138, 545);
            button1.Name = "button1";
            button1.Size = new Size(115, 60);
            button1.TabIndex = 15;
            button1.Text = "Update index";
            button1.UseVisualStyleBackColor = false;
            button1.Click += UpdateIndex_bt_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(tx_Id);
            panel5.Location = new Point(20, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(500, 80);
            panel5.TabIndex = 16;
            // 
            // Exit_bt
            // 
            Exit_bt.BackColor = Color.Indigo;
            Exit_bt.Enabled = false;
            Exit_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Exit_bt.ForeColor = Color.White;
            Exit_bt.Location = new Point(631, 545);
            Exit_bt.Name = "Exit_bt";
            Exit_bt.Size = new Size(115, 60);
            Exit_bt.TabIndex = 17;
            Exit_bt.Text = "Exit";
            Exit_bt.UseVisualStyleBackColor = false;
            Exit_bt.Click += Exit_bt_Click;
            // 
            // SHEET
            // 
            SHEET.BackColor = Color.Indigo;
            SHEET.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SHEET.ForeColor = Color.White;
            SHEET.Location = new Point(947, 654);
            SHEET.Name = "SHEET";
            SHEET.Size = new Size(144, 61);
            SHEET.TabIndex = 2;
            SHEET.Text = "GO TO THE SHEET";
            SHEET.UseVisualStyleBackColor = false;
            // 
            // search_bt
            // 
            search_bt.BackColor = Color.Indigo;
            search_bt.Enabled = false;
            search_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            search_bt.ForeColor = Color.White;
            search_bt.Location = new Point(510, 545);
            search_bt.Name = "search_bt";
            search_bt.Size = new Size(115, 60);
            search_bt.TabIndex = 18;
            search_bt.Text = "Search";
            search_bt.UseVisualStyleBackColor = false;
            search_bt.Click += Search_bt_Click;
            // 
            // delete_bt
            // 
            delete_bt.BackColor = Color.Indigo;
            delete_bt.Enabled = false;
            delete_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            delete_bt.ForeColor = Color.White;
            delete_bt.Location = new Point(510, 468);
            delete_bt.Name = "delete_bt";
            delete_bt.Size = new Size(115, 60);
            delete_bt.TabIndex = 19;
            delete_bt.Text = "Delete";
            delete_bt.UseVisualStyleBackColor = false;
            delete_bt.Click += Delete_bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_08_at_21_12_35_0ff9bb80;
            ClientSize = new Size(1029, 613);
            Controls.Add(delete_bt);
            Controls.Add(search_bt);
            Controls.Add(Exit_bt);
            Controls.Add(panel5);
            Controls.Add(button1);
            Controls.Add(LoadIndex_bt);
            Controls.Add(textBox1);
            Controls.Add(EndOfFile_bt);
            Controls.Add(StartOfFile_bt);
            Controls.Add(Clear_bt);
            Controls.Add(InsertToFile_bt);
            Controls.Add(ReadFromFile_bt);
            Controls.Add(OpenFile_bt);
            Controls.Add(label4);
            Controls.Add(tx_days);
            Controls.Add(SHEET);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(150, 50);
            Name = "Form1";
            Text = "SALARY ";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private TextBox tx_name;
        private Label label2;
        private Panel panel1;
        private TextBox tx_hour;
        private Label label1;
        private Panel panel4;
        private TextBox tx_rate;
        private Label label3;
        private TextBox tx_days;
        private Label label4;
        private Button OpenFile_bt;
        private Button ReadFromFile_bt;
        private Button InsertToFile_bt;
        private Button Clear_bt;
        private Button StartOfFile_bt;
        private Button EndOfFile_bt;
        private TextBox textBox1;
        private Button LoadIndex_bt;
        private TextBox tx_Id;
        private Label label5;
        private Button button1;
        private Panel panel5;
        private Button Exit_bt;
        private Button SHEET;
        private Button search_bt;
        private Button delete_bt;
    }
}