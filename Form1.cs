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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] array = {15, 65, 89, 18, 75, 13, 1};
            int[] b;

            // MERGE SORT --- ANDY
            // MergeSort a = new MergeSort();
            // b = a.mergeSort(array);

            // BUBBLE SORT --- MARTI
            // BubbleSort a = new BubbleSort();
            // b = a.Bubble_sort(array);



            foreach (int c in b)
            {
                listBox1.Items.Add(c);
            }

        }
    }
}
