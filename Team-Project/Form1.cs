using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace Team_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FileStream MyFile;
        StreamReader sr;
        StreamWriter sw;
        string FileName;
        private void NameButton_Click(object sender, EventArgs e)
        {
            // Get the text from the multi-line text box
            string[] lines = tx_name.Text.Split('\n');


            // Clear the list box
            listBox1.Items.Clear();

            // Add each line of text to the list box
            foreach (string line in lines)
            {
                if (line != "")
                {
                    listBox1.Items.Add(line);
                }
            }
        }
        private void Hourbutton_Click(object sender, EventArgs e)
        {
            // Get the text from the multi-line text box
            string[] lines = tx_hour.Text.Split('\n');


            // Clear the list box
            listBox2.Items.Clear();

            // Add each line of text to the list box
            foreach (string line in lines)
            {
                if (line != "")
                {
                    listBox2.Items.Add(line);
                }
            }
        }
        private void RateButton_Click(object sender, EventArgs e)
        {
            // Get the text from the multi-line text box
            string[] lines = tx_rate.Text.Split('\n');


            // Clear the list box
            listBox3.Items.Clear();

            // Add each line of text to the list box
            foreach (string line in lines)
            {
                if (line != "")
                {
                    listBox3.Items.Add(line);
                }
            }
        }
        public void SHEET_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form1 = new Form2(listBox1, listBox2, listBox3, tx_days);
            form1.ShowDialog();
            this.Show();
        }

        private void ReadFromFile_bt_Click(object sender, EventArgs e)
        {
            string record = sr.ReadLine();
            string[] fields;
            if (record != null)
            {
                fields = record.Split(',');
                tx_name.Text = fields[0];
                tx_hour.Text = fields[1];
                tx_rate.Text = fields[2];
                tx_days.Text = fields[3];
            }
            else
            {
                MessageBox.Show("no more records");
                Clear_bt_Click(sender, e);
            }
        }

        private void OpenFile_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            FileName = ofd.FileName;
            MyFile = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(MyFile);
            sr = new StreamReader(MyFile);
            MessageBox.Show("File is opened");
            ReadFromFile_bt.Enabled = true;
            InsertToFile_bt.Enabled = true;
            Clear_bt.Enabled = true;
        }

        private void InsertToFile_bt_Click(object sender, EventArgs e)
        {
            string record = tx_name.Text + "," + tx_hour.Text + "," + tx_rate.Text + "," + tx_days.Text;
            sw.WriteLine(record);
            sw.Flush();
            MessageBox.Show("Record Saved");
        }

        private void Clear_bt_Click(object sender, EventArgs e)
        {
            tx_days.Text = tx_hour.Text = tx_rate.Text = tx_days.Text = listBox1.Text = listBox2.Text = listBox3.Text = null;
        }

        private void StartOfFile_bt_Click(object sender, EventArgs e)
        {
            MyFile.Seek(0, SeekOrigin.Begin);
            MessageBox.Show("Begin of file");
        }

        private void EndOfFile_bt_Click(object sender, EventArgs e)
        {
            MyFile.Seek(0, SeekOrigin.End);
            MessageBox.Show("End of file");
        }
    }
}