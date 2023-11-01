using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            /*
            int[] array = {15, 65, 89, 18, 75, 13, 1};
            int[] b;

            // MERGE SORT --- ANDY
            // MergeSort a = new MergeSort();
            // b = a.mergeSort(array);

            // BUBBLE SORT --- MARTI
            // BubbleSort a = new BubbleSort();
            // b = a.Bubble_sort(array);

            // QUICK SORT --- BORDIGA
             QuickSort a = new QuickSort();
             b = a.Quick_Sort(array);

            foreach (int c in b)
            {
                listBox1.Items.Add(c);
            }
            */
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton1.Checked)
            {
                listBox1.Items.Clear();
                QuickSort a = new QuickSort();
                b = a.Quick_Sort(array);

                foreach (int c in b)
                {
                    listBox1.Items.Add(c);
                }
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
                BubbleSort a = new BubbleSort();
                b = a.Bubble_sort(array);

                foreach (int c in b)
                {
                    listBox1.Items.Add(c);
                }
            }
            else if (radioButton3.Checked)
            {
                listBox1.Items.Clear();
                MergeSort a = new MergeSort();
                b = a.mergeSort(array);

                foreach (int c in b)
                {
                    listBox1.Items.Add(c);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un metodo de ordenamiento");
            }
        }
    }
}
