using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Form2 form1 = new Form2(listBox1, listBox2, listBox3, textBox4);
            form1.ShowDialog();
            this.Show();
        }


      

    }
}