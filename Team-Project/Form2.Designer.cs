namespace Team_Project
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            saveToExcelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(77, 78);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(719, 319);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = Color.Indigo;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.Indigo;
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Salary";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(148, 458);
            button1.Name = "button1";
            button1.Size = new Size(187, 64);
            button1.TabIndex = 3;
            button1.Text = "CREATE THE SHEET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.undo_icon_symbol_design_illustration_vector1;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(40, 34);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += back;
            // 
            // saveToExcelButton
            // 
            saveToExcelButton.BackColor = Color.Indigo;
            saveToExcelButton.Cursor = Cursors.Hand;
            saveToExcelButton.ForeColor = SystemColors.ButtonHighlight;
            saveToExcelButton.Location = new Point(558, 458);
            saveToExcelButton.Name = "saveToExcelButton";
            saveToExcelButton.Size = new Size(187, 64);
            saveToExcelButton.TabIndex = 4;
            saveToExcelButton.Text = "SAVE TO EXCEL";
            saveToExcelButton.UseVisualStyleBackColor = false;
            saveToExcelButton.Click += saveToExcelButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_12_16_at_13_26_47_810e81cc;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(907, 543);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(saveToExcelButton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button saveToExcelButton;
    }
}