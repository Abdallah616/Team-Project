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

        private void saveToExcelButton_Click(object sender, EventArgs e)
        {
            SaveToExcel();
        }
        private void SaveToExcel()
        {
            //try
            //{
            //    // Create a new Excel application
            //    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //    excelApp.Visible = true;

            //    // Create a new workbook and add a worksheet
            //    Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            //    Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

            //    // Copy data from DataGridView to Excel worksheet      //2D Array
            //    worksheet.Cells[1, 1] = "Name";
            //    worksheet.Cells[1, 2] = "Salaray";
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            // Check for null values before accessing the Value property
            //            object cellValue = dataGridView1[j, i].Value;
            //            worksheet.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : "";
            //        }
            //    }


            //    // Save the workbook
            //    workbook.SaveAs(@"C:\Users\friends\OneDrive\Desktop\test\test");

            //    // Release Excel objects

            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            //}
            //catch (Exception ex)
            //{
            //    // Handle exceptions, log, or show an error message
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float days = float.Parse(textBox4.Text);// Initialize tx == text box for days

            int[] rate = new int[listBox2.Items.Count]; // Initialize rate array

            float[] T = new float[listBox2.Items.Count]; // Initialize T array

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                rate[i] = Convert.ToInt32(listBox3.Items[i]); //rate[]== rate
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                // Parse each item in the list
                if (float.TryParse(listBox2.Items[i].ToString(), out float x))
                {
                    int[] rate_2 = new int[listBox2.Items.Count]; // Initialize rate_2 array

                    float[] r1 = new float[listBox2.Items.Count]; // Initialize r1 array ==fun

                    float[] r2 = new float[listBox2.Items.Count]; // Initialize r2 array== doubl fun

                    rate_2[i] = rate[i] * 2;
                    r1[i] = rate[i] * x;
                    r2[i] = ((40 * rate[i]) + ((x - 40) * rate_2[i]));

                    if (x <= 40)
                    {
                        T[i] = r1[i] * (days / 7);
                    }
                    else
                    {
                        T[i] = r2[i] * (days / 7);
                    }
                }
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                dataGridView1.Rows.Add(listBox1.Items[i], T[i]);
            }
        }

        private void back(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}