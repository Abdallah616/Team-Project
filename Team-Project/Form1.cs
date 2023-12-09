using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void button2_Click(object sender, EventArgs e)
        {

            int[] z = new int[listBox1.Items.Count]; // Initialize z array
            double[] T = new double[listBox1.Items.Count]; // Initialize T array

            for (int o = 0; o < listBox1.Items.Count; o++)
            {
                z[o] = Convert.ToInt32(listBox3.Items[o]);
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Parse each item in the list
                if (float.TryParse(listBox1.Items[i].ToString(), out float x))
                {
                    int[] z2 = new int[listBox1.Items.Count]; // Initialize z2 array
                    float[] r1 = new float[listBox1.Items.Count]; // Initialize r1 array
                    float[] r2 = new float[listBox1.Items.Count]; // Initialize r2 array

                    z2[i] = z[i] * 2;
                    r1[i] = z[i] * x;
                    r2[i] = ((40 * z[i]) + ((x - 40) * z2[i]));

                    if (x <= 40)
                    {
                        T[i] = r1[i] * 4;
                    }
                    else
                    {
                        T[i] = r2[i] * 4;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input in listBox1. Please enter valid numeric values.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text from the multi-line text box
            string[] lines = tx_name.Text.Split('\n');


            // Clear the list box
            listBox1.Items.Clear();

            // Add each line of text to the list box
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Get the text from the multi-line text box
            string[] lines = tx_hour.Text.Split('\n');


            // Clear the list box
            listBox2.Items.Clear();

            // Add each line of text to the list box
            foreach (string line in lines)
            {
                listBox2.Items.Add(line);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SHEET_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2(listBox1, listBox2, listBox3, textBox4);
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            // Get the text from the multi-line text box
            string[] lines = tx_rate.Text.Split('\n');


            // Clear the list box
            listBox3.Items.Clear();

            // Add each line of text to the list box
            foreach (string line in lines)
            {
                listBox3.Items.Add(line);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}