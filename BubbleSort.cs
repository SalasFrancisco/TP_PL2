using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class BubbleSort
    {
        public (int[], int, long) Bubble_sort(int[] vec)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int temp;
            bool mar;
            int movimientos = 0;

            for (var i = 0; i < vec.Length - 1; i++)
            {
                mar = false;
                for (var j = 0; j < vec.Length - 1; j++)
                {
                    if (vec[j] > vec[j + 1])
                    {
                        temp = vec[j];
                        vec[j] = vec[j + 1];
                        vec[j + 1] = temp;
                        mar = true;
                        movimientos++;
                    }
                }
                if (mar == false)
                {
                    stopwatch.Stop();
                    long tiempo = stopwatch.ElapsedMilliseconds;
                    return (vec, movimientos,tiempo);
                    
                }
            }
            stopwatch.Stop();
            long tiemp = stopwatch.ElapsedMilliseconds;
            return (vec, movimientos, tiemp);
        }

    }
}
