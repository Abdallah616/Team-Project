﻿namespace Team_Project
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
            textBox4 = new TextBox();
            label4 = new Label();
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(NameButton);
            panel3.Controls.Add(tx_name);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Palatino Linotype", 24F, FontStyle.Italic, GraphicsUnit.Point);
            panel3.Location = new Point(22, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 131);
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
            NameButton.Click += new EventHandler(NameButton_Click);
            // 
            // tx_name
            // 
            tx_name.BackColor = Color.White;
            tx_name.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_name.Location = new Point(150, 50);
            tx_name.Multiline = true;
            tx_name.Name = "tx_name";
            tx_name.Size = new Size(281, 39);
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
            label2.Text = "Name";
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
            SHEET.Click += new EventHandler(SHEET_Click);
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
            No_Of_HoursButton.Text = "INPUT DATA";
            No_Of_HoursButton.UseVisualStyleBackColor = false;
            No_Of_HoursButton.Click += new EventHandler(Hourbutton_Click);
            // 
            // tx_hour
            // 
            tx_hour.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_hour.Location = new Point(150, 50);
            tx_hour.Multiline = true;
            tx_hour.Name = "tx_hour";
            tx_hour.Size = new Size(281, 39);
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
            panel4.Location = new Point(22, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(625, 131);
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
            RateButton.Text = "INPUT DATA";
            RateButton.UseVisualStyleBackColor = false;
            RateButton.Click +=new EventHandler(RateButton_Click);
            // 
            // tx_rate
            // 
            tx_rate.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            tx_rate.Location = new Point(150, 50);
            tx_rate.Multiline = true;
            tx_rate.Name = "tx_rate";
            tx_rate.Size = new Size(281, 39);
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
            label3.Text = "Rate";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Palatino Linotype", 18F, FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(376, 554);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 40);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(186, 556);
            label4.Name = "label4";
            label4.Size = new Size(160, 27);
            label4.Text = "Days Works";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_08_at_21_12_35_0ff9bb80;
            ClientSize = new Size(913, 727);
            Controls.Add(label4);
            Controls.Add(textBox4);
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
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
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
        private TextBox textBox4;
        private Label label4;
    }
}