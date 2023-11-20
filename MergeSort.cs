using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MergeSort
    {
        public (int[], int, long) mergeSort(int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); 
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            long tiempo = 0;

            if (array.Length <= 1)
            {
                stopwatch.Stop();
                tiempo = stopwatch.ElapsedMilliseconds;
                return (array, 0, tiempo);
            }

            int midPoint = array.Length / 2;  

            left = new int[midPoint];
  

            if (array.Length % 2 == 0)
            {
                right = new int[midPoint];
                
            }
            else
            {
                right = new int[midPoint + 1];
                
            } 
            for (int i = 0; i < midPoint; i++)
            {

                left[i] = array[i];
            }
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            var leftResult = mergeSort(left);
            var rightResult = mergeSort(right);

            left = leftResult.Item1;
            right = rightResult.Item1;

            int leftMovimientos = leftResult.Item2;
            int rightMovimientos = rightResult.Item2;
            var mergeResult = merge(left, right);

            result = mergeResult.Item1;
            int mergeMovimientos = mergeResult.Item2;
            int totalMovimientos = leftMovimientos + rightMovimientos + mergeMovimientos;
            stopwatch.Stop();
            long tiemp = stopwatch.ElapsedMilliseconds;
            return (result, totalMovimientos, tiemp);
        }
  
        public (int[], int) merge(int[] left, int[] right)
        {
            int movimientos = 0;
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;  
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)  
                {  
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        movimientos++;
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        movimientos++;
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    movimientos++;
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    movimientos++;
                    indexRight++;
                    indexResult++;
                }  
            }
            return (result, movimientos);
        }
    }
}
