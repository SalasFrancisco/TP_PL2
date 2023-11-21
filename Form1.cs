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
            // Crea un diccionario y agrega el valor de 'i' como clave y valor
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(i.ToString(), i);
            int s = 0;
            // Recorre el diccionario y agrega cada valor al gráfico 'chart2'
            foreach (KeyValuePair<string, int> d in dic)
            {
                chart2.Series["DATOS"].Points.AddXY(s, d.Value);
                // Actualiza el gráfico para reflejar los cambios
                chart2.Refresh();
                s++;
            }
        }

        public void Graficar(int c)
        {
            // Similar a 'Graficar2', pero agrega los valores al gráfico 'chart1'
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
            // Verifica si el campo de texto 'txtLimite' no está vacío
            if (txtLimite.Text != "")
            {
                // Limpia los puntos de los gráficos 'chart1' y 'chart2'
                chart1.Series["DATOS"].Points.Clear();
                chart2.Series["DATOS"].Points.Clear();
                // Crea un arreglo de tamaño 'txtLimite' y lo llena con números aleatorios
                int[] array = new int[Convert.ToInt32(txtLimite.Text)];
                Random random = new Random();
                int x = 0;
                int[] b;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 1000);
                }

                // Grafica los valores del arreglo en 'chart2'
                for (int i = 0; i < array.Length; i++)
                {
                    x = array[i];
                    Graficar2(x);
                }

                // Dependiendo de qué botón de opción esté seleccionado, se ordena el arreglo con el algoritmo correspondiente
                // y se grafican los valores ordenados en 'chart1'
                (int[], int) mergeResult;
                (int[], int, long) sortResult;
                if (radioButton1.Checked)
                {
                    QuickSort a = new QuickSort();
                    sortResult = a.Quick_Sort(array);
                    b = sortResult.Item1;

                    dataGridView1.Rows.Add("Quick Sort", txtLimite.Text, sortResult.Item3 + " milisegundos", sortResult.Item2);
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
                    dataGridView1.Rows.Add("Bubble Sort", txtLimite.Text, sortResult.Item3 + " milisegundos", sortResult.Item2);
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

                    dataGridView1.Rows.Add("Merge Sort", txtLimite.Text, sortResult.Item3 + " milisegundos", sortResult.Item2);
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
                    // Si no se seleccionó ningún botón de opción, muestra un mensaje de error
                    MessageBox.Show("Debe seleccionar un metodo de ordenamiento");
                }
            }
            else
            {
                // Si el campo de texto 'txtLimite' está vacío, muestra un mensaje de error
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
