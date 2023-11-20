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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int tamaño = arr.Length;
            long tiempo;

            if (tamaño <= 1)
            {
                stopwatch.Stop();
                tiempo = stopwatch.ElapsedTicks;
                return (arr, 0, tiempo);
            }
            int pivot = arr[0];
            List<int> izq = new List<int>();
            List<int> der = new List<int>();
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

            var sortResultIzq = Quick_Sort(izq.ToArray());
            var sortResultDer = Quick_Sort(der.ToArray());

            int[] arrayIzq = sortResultIzq.Item1;
            int[] arrayDer = sortResultDer.Item1;
            int movimientos = sortResultIzq.Item2 + sortResultDer.Item2 + 1;

            stopwatch.Stop();
            tiempo = stopwatch.ElapsedMilliseconds;
            return (arrayIzq.Concat(new int[] { pivot }).Concat(arrayDer).ToArray(), movimientos, tiempo);
        }



    }
}
