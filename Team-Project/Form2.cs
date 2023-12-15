using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project
{
    public partial class Form2 : Form
    {
        ListBox listBox1;
        ListBox listBox2;
        ListBox listBox3;
        TextBox textBox4;
        public Form2(ListBox listBox1, ListBox listBox2, ListBox listBox3, TextBox textBox4)
        {

            this.listBox1 = listBox1;
            this.listBox2 = listBox2;
            this.listBox3 = listBox3;
            this.textBox4 = textBox4;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            float tx = float.Parse(textBox4.Text);
            int[] z = new int[listBox2.Items.Count]; // Initialize z array
            float[] T = new float[listBox2.Items.Count]; // Initialize T array

            for (int o = 0; o < listBox2.Items.Count; o++)
            {
                z[o] = Convert.ToInt32(listBox3.Items[o]);
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                // Parse each item in the list
                if (float.TryParse(listBox2.Items[i].ToString(), out float x))
                {
                    int[] z2 = new int[listBox2.Items.Count]; // Initialize z2 array
                    float[] r1 = new float[listBox2.Items.Count]; // Initialize r1 array
                    float[] r2 = new float[listBox2.Items.Count]; // Initialize r2 array

                    z2[i] = z[i] * 2;
                    r1[i] = z[i] * x;
                    r2[i] = ((40 * z[i]) + ((x - 40) * z2[i]));

                    if (x <= 40)
                    {
                        T[i] = r1[i] * (tx / 7);
                    }
                    else
                    {
                        T[i] = r2[i] * (tx / 7);
                    }
                }
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                dataGridView1.Rows.Add(listBox1.Items[i], T[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}