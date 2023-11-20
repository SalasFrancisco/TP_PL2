using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int[] array = { 15, 65, 89, 18, 75, 13, 1 };
        int[] b;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public void Graficar2(int i)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(i.ToString(), i);
            int s = 0;
            foreach (KeyValuePair<string, int> d in dic)
            {
                chart2.Series["DATOS"].Points.AddXY(s, d.Value);
                chart2.Refresh();
                s++;

            }
        }
        public void Graficar(int c)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(c.ToString(), c);
            int s = 0;
            foreach (KeyValuePair<string, int> d in dic)
            {
                chart1.Series["DATOS"].Points.AddXY(s, d.Value);
                chart1.Refresh();
                s++;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLimite.Text != "")
            {
                chart1.Series["DATOS"].Points.Clear();
                chart2.Series["DATOS"].Points.Clear();
                int[] array = new int[Convert.ToInt32(txtLimite.Text)];
                Random random = new Random();
                int x = 0;
                int[] b;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 1000);
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    x = array[i];
                    Graficar2(x);
                }
                
                (int[], int) mergeResult;
                (int[], int, long) sortResult;
                if (radioButton1.Checked)
                {
                    QuickSort a = new QuickSort();
                    sortResult = a.Quick_Sort(array);
                    b = sortResult.Item1;

                    dataGridView1.Rows.Add("Quick Sort", txtLimite.Text, sortResult.Item3, sortResult.Item2);
                    textBox2.Text = sortResult.Item3.ToString();
                    textBox3.Text = sortResult.Item2.ToString();
                    foreach (int c in b)
                    {
                        Graficar(c);
                    }

                }
                else if (radioButton2.Checked)
                {
                    BubbleSort a = new BubbleSort();
                    sortResult = a.Bubble_sort(array);
                    b = sortResult.Item1;
                    dataGridView1.Rows.Add("Bubble Sort", txtLimite.Text, sortResult.Item3, sortResult.Item2);
                    textBox2.Text = sortResult.Item3.ToString();
                    textBox3.Text = sortResult.Item2.ToString();
                    foreach (int c in b)
                    {
                        Graficar(c);
                    }
                }
                else if (radioButton3.Checked)
                {
                    MergeSort a = new MergeSort();
                    sortResult = a.mergeSort(array);

                    dataGridView1.Rows.Add("Merge Sort", txtLimite.Text, sortResult.Item3, sortResult.Item2);
                    b = sortResult.Item1;
                    textBox2.Text = sortResult.Item3.ToString();
                    textBox3.Text = sortResult.Item2.ToString();
                    foreach (int c in b)
                    {
                        Graficar(c);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un metodo de ordenamiento");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Valor Límite");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
