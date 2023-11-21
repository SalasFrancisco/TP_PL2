using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class QuickSort
    {
        public (int[], int, long) Quick_Sort(int[] arr)
        {
            // Inicia un cronómetro para medir el tiempo de ejecución del algoritmo
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Obtiene el tamaño del arreglo
            int tamaño = arr.Length;
            long tiempo = 0;

            // Si el tamaño del arreglo es menor o igual a 1, se detiene el cronómetro y se devuelve el arreglo original
            if (tamaño <= 1)
            {
                stopwatch.Stop();
                tiempo = stopwatch.ElapsedTicks;
                return (arr, 0, tiempo);
            }

            // Selecciona el primer elemento del arreglo como pivote
            int pivot = arr[0];

            // Crea dos listas para almacenar los elementos menores y mayores que el pivote
            List<int> izq = new List<int>();
            List<int> der = new List<int>();

            // Recorre el arreglo y divide los elementos en las dos listas
            int i;
            for (i = 1; i < tamaño; i++)
            {
                if (arr[i] < pivot)
                {
                    izq.Add(arr[i]);
                }
                else
                {
                    der.Add(arr[i]);
                }
            }

            // Llama recursivamente a la función Quick_Sort para las dos listas
            var sortResultIzq = Quick_Sort(izq.ToArray());
            var sortResultDer = Quick_Sort(der.ToArray());

            // Obtiene los arreglos ordenados y la cantidad de movimientos realizados
            int[] arrayIzq = sortResultIzq.Item1;
            int[] arrayDer = sortResultDer.Item1;
            int movimientos = sortResultIzq.Item2 + sortResultDer.Item2 + 1;

            // Detiene el cronómetro y obtiene el tiempo transcurrido
            stopwatch.Stop();
            tiempo = stopwatch.ElapsedMilliseconds;

            // Devuelve el arreglo ordenado, la cantidad de movimientos y el tiempo transcurrido
            return (arrayIzq.Concat(new int[] { pivot }).Concat(arrayDer).ToArray(), movimientos, tiempo);
        }
    }

}
