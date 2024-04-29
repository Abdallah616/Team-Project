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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        FileStream salaryFile;
        StreamReader sr;
        StreamWriter sw;
        string FileName;
        SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

        private void ReadFromFile_bt_Click(object sender, EventArgs e)
        {
            string record = sr.ReadLine();
            string[] fields;
            if (record != null)
            {
                fields = record.Split('|');
                tx_Id.Text = fields[0];
                tx_name.Text = fields[1];
                tx_hour.Text = fields[2];
                tx_rate.Text = fields[3];
                tx_days.Text = fields[4];
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
            StartOfFile_bt.Enabled = true;
            EndOfFile_bt.Enabled = true;
            LoadIndex_bt.Enabled = true;
            button1.Enabled = true;
            Exit_bt.Enabled = true;
            search_bt.Enabled = true;
            delete_bt.Enabled = true;
        }

        private void InsertToFile_bt_Click(object sender, EventArgs e)
        {
            MyFile.Seek(0, SeekOrigin.End);
            int loc = (int)MyFile.Position;
            sw.WriteLine($"{tx_Id.Text}|{tx_name.Text}|{tx_hour.Text}|{tx_rate.Text}|{tx_days.Text}|{CalculateSalary()}");
            sw.Flush();
            dict.Add(int.Parse(tx_Id.Text), loc);
            MessageBox.Show("Inserted");
        }

        private double CalculateSalary()
        {
            double wage,weeks;
            double hours = double.Parse(tx_hour.Text);
            double rate = double.Parse(tx_rate.Text);
            double days = double.Parse(tx_days.Text);
            if(hours > 40)
            {
                wage = (hours - 40) * (rate * 2);
                wage = wage + (40 * rate);
            }
            else
            wage = hours * rate;
            weeks = days / 7;
            return weeks * wage;
        }


        private void Clear_bt_Click(object sender, EventArgs e)
        {
            tx_Id.Text = tx_name.Text = tx_hour.Text = tx_rate.Text = tx_days.Text = null;
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

        private void LoadIndex_bt_Click(object sender, EventArgs e)
        {
            dict.Clear();
            textBox1.Clear();
            textBox1.Text = "Index File :\r\n-------------\r\nkey\t\tloc\r\n";
            string line;
            StreamReader isr;
            if (File.Exists("index.txt"))
            {
                isr = new StreamReader("index.txt");
                while ((line = isr.ReadLine()) != null)
                {
                    string[] arr = line.Split('|');

                    textBox1.Text += arr[0] + "\t\t" + arr[1] + Environment.NewLine;

                    dict.Add(int.Parse(arr[0]), int.Parse(arr[1]));
                }
                isr.Close();
                MessageBox.Show("Index File Loaded in dic.");
                //return;
            }

        }

        private void UpdateIndex_bt_Click(object sender, EventArgs e)
        {
            StreamWriter isw = new StreamWriter("index.txt");
            foreach (KeyValuePair<int, int> item in dict)
            {
                isw.WriteLine($"{item.Key}|{item.Value}");
            }
            isw.Close();
            MessageBox.Show("Done rewrite");
        }

        public bool BS(int[] arr, int K) //binary search method to use it in the search button
        {
            int f = 0, L = arr.Length - 1; int mid = (f + L) / 2;
            while (f <= L)
            {
                mid = (f + L) / 2;
                if (K < arr[mid])
                {
                    L = mid - 1;
                }
                else if (K > arr[mid])
                    f = mid + 1;
                else
                    return true;
            }
            return false;
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            if (BS(dict.Keys.ToArray(), int.Parse(tx_Id.Text)))
            {
                MyFile.Seek(dict[int.Parse(tx_Id.Text)], SeekOrigin.Begin);
                string line = sr.ReadLine();
                string[] arr = line.Split('|');
                tx_Id.Text = arr[0];
                tx_name.Text = arr[1];
                tx_hour.Text = arr[2];
                tx_rate.Text = arr[3];
                tx_days.Text = arr[4];
                return;
            }
            MessageBox.Show("Not Found");
        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            sw.Close();
            sr.Close();
            MyFile.Close();
            Dispose();
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            if (BS(dict.Keys.ToArray(), int.Parse(tx_Id.Text)))
            {
                MyFile.Seek(dict[int.Parse(tx_Id.Text)], SeekOrigin.Begin);
                sw.Write("*");
                sw.Flush();
                dict.Remove(int.Parse(tx_Id.Text));
                MessageBox.Show("done");
                return;
            }
            MessageBox.Show("Not Found");
        }
    }
}