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
            NameButton = new Button();
            tx_name = new TextBox();
            label2 = new Label();
            SHEET = new Button();
            panel1 = new Panel();
            No_Of_HoursButton = new Button();
            tx_hour = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            RateButton = new Button();
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            LoadIndex_bt = new Button();
            tx_Id = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            Exit_bt = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(NameButton);
            panel3.Controls.Add(tx_name);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel3.Location = new Point(22, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 100);
            panel3.TabIndex = 6;
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
            NameButton.Click += NameButton_Click;
            // 
            // tx_name
            // 
            tx_name.BackColor = Color.White;
            tx_name.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_name.Location = new Point(147, 31);
            tx_name.Multiline = true;
            tx_name.Name = "tx_name";
            tx_name.Size = new Size(281, 39);
            tx_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(17, 33);
            label2.Name = "label2";
            label2.Size = new Size(113, 37);
            label2.TabIndex = 5;
            label2.Text = "Name";
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
            SHEET.Click += SHEET_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(No_Of_HoursButton);
            panel1.Controls.Add(tx_hour);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(22, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 131);
            panel1.TabIndex = 5;
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
            No_Of_HoursButton.TabIndex = 0;
            No_Of_HoursButton.Text = "INPUT DATA";
            No_Of_HoursButton.UseVisualStyleBackColor = false;
            No_Of_HoursButton.Click += Hourbutton_Click;
            // 
            // tx_hour
            // 
            tx_hour.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_hour.Location = new Point(150, 50);
            tx_hour.Multiline = true;
            tx_hour.Name = "tx_hour";
            tx_hour.Size = new Size(281, 39);
            tx_hour.TabIndex = 1;
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
            label1.TabIndex = 2;
            label1.Text = "Hours";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(RateButton);
            panel4.Controls.Add(tx_rate);
            panel4.Controls.Add(label3);
            panel4.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel4.Location = new Point(22, 364);
            panel4.Name = "panel4";
            panel4.Size = new Size(625, 105);
            panel4.TabIndex = 4;
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
            RateButton.TabIndex = 0;
            RateButton.Text = "INPUT DATA";
            RateButton.UseVisualStyleBackColor = false;
            RateButton.Click += RateButton_Click;
            // 
            // tx_rate
            // 
            tx_rate.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_rate.Location = new Point(150, 50);
            tx_rate.Multiline = true;
            tx_rate.Name = "tx_rate";
            tx_rate.Size = new Size(281, 39);
            tx_rate.TabIndex = 1;
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
            label3.TabIndex = 2;
            label3.Text = "Rate";
            // 
            // tx_days
            // 
            tx_days.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_days.Location = new Point(251, 561);
            tx_days.Name = "tx_days";
            tx_days.Size = new Size(242, 40);
            tx_days.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(22, 567);
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
            OpenFile_bt.Location = new Point(39, 645);
            OpenFile_bt.Name = "OpenFile_bt";
            OpenFile_bt.Size = new Size(92, 61);
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
            ReadFromFile_bt.Location = new Point(137, 645);
            ReadFromFile_bt.Name = "ReadFromFile_bt";
            ReadFromFile_bt.Size = new Size(115, 61);
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
            InsertToFile_bt.Location = new Point(269, 645);
            InsertToFile_bt.Name = "InsertToFile_bt";
            InsertToFile_bt.Size = new Size(111, 61);
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
            Clear_bt.Location = new Point(401, 645);
            Clear_bt.Name = "Clear_bt";
            Clear_bt.Size = new Size(92, 61);
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
            StartOfFile_bt.Location = new Point(499, 645);
            StartOfFile_bt.Name = "StartOfFile_bt";
            StartOfFile_bt.Size = new Size(92, 61);
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
            EndOfFile_bt.Location = new Point(597, 645);
            EndOfFile_bt.Name = "EndOfFile_bt";
            EndOfFile_bt.Size = new Size(92, 61);
            EndOfFile_bt.TabIndex = 12;
            EndOfFile_bt.Text = "End Of File";
            EndOfFile_bt.UseVisualStyleBackColor = false;
            EndOfFile_bt.Click += EndOfFile_bt_Click;
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
            listBox1.TabIndex = 2;
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
            listBox2.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(1231, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 484);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(694, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 451);
            textBox1.TabIndex = 13;
            // 
            // LoadIndex_bt
            // 
            LoadIndex_bt.BackColor = Color.Indigo;
            LoadIndex_bt.Enabled = false;
            LoadIndex_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoadIndex_bt.ForeColor = Color.White;
            LoadIndex_bt.Location = new Point(839, 522);
            LoadIndex_bt.Name = "LoadIndex_bt";
            LoadIndex_bt.Size = new Size(92, 61);
            LoadIndex_bt.TabIndex = 14;
            LoadIndex_bt.Text = "Load Index";
            LoadIndex_bt.UseVisualStyleBackColor = false;
            LoadIndex_bt.Click += button1_Click;
            // 
            // tx_Id
            // 
            tx_Id.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_Id.Location = new Point(147, 32);
            tx_Id.Multiline = true;
            tx_Id.Name = "tx_Id";
            tx_Id.Size = new Size(284, 39);
            tx_Id.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Lucida Fax", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(29, 32);
            label5.Name = "label5";
            label5.Size = new Size(50, 37);
            label5.TabIndex = 4;
            label5.Text = "Id";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Enabled = false;
            button1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(694, 522);
            button1.Name = "button1";
            button1.Size = new Size(92, 61);
            button1.TabIndex = 15;
            button1.Text = "Rewrite";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(tx_Id);
            panel5.Location = new Point(22, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(622, 89);
            panel5.TabIndex = 16;
            // 
            // Exit_bt
            // 
            Exit_bt.BackColor = Color.Indigo;
            Exit_bt.Enabled = false;
            Exit_bt.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Exit_bt.ForeColor = Color.White;
            Exit_bt.Location = new Point(695, 645);
            Exit_bt.Name = "Exit_bt";
            Exit_bt.Size = new Size(92, 61);
            Exit_bt.TabIndex = 17;
            Exit_bt.Text = "Exit";
            Exit_bt.UseVisualStyleBackColor = false;
            Exit_bt.Click += Exit_bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_08_at_21_12_35_0ff9bb80;
            ClientSize = new Size(1468, 727);
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
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SHEET;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button No_Of_HoursButton;
        private System.Windows.Forms.TextBox tx_hour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button RateButton;
        private System.Windows.Forms.TextBox tx_rate;
        private System.Windows.Forms.Label label3;
        private TextBox tx_days;
        private Label label4;
        private Button OpenFile_bt;
        private Button ReadFromFile_bt;
        private Button InsertToFile_bt;
        private Button Clear_bt;
        private Button StartOfFile_bt;
        private Button EndOfFile_bt;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Panel panel2;
        private TextBox textBox1;
        private Button LoadIndex_bt;
        private TextBox tx_Id;
        private Label label5;
        private Button button1;
        private Panel panel5;
        private Button Exit_bt;
    }
}