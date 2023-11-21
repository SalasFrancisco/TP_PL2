using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MergeSort
    {
        // Esta función implementa el algoritmo de ordenamiento Merge Sort.
        public (int[], int, long) mergeSort(int[] array)
        {
            // Iniciamos un Stopwatch para medir el tiempo que tarda el algoritmo.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Creamos los arrays left, right y result.
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            // Si el array tiene longitud 1 o menos, ya está ordenado.
            if (array.Length <= 1)
            {
                // Detenemos el Stopwatch y devolvemos el array junto con 0 como el número de movimientos y el tiempo transcurrido.
                stopwatch.Stop();
                long tiempo = stopwatch.ElapsedMilliseconds;
                return (array, 0, tiempo);
            }

            // Calculamos el punto medio del array.
            int midPoint = array.Length / 2;

            // Creamos los arrays left y right.
            left = new int[midPoint];
            if (array.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }

            // Llenamos los arrays left y right con los elementos correspondientes del array original.
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

            // Ordenamos recursivamente los arrays left y right.
            var leftResult = mergeSort(left);
            var rightResult = mergeSort(right);

            // Obtenemos los arrays ordenados y el número de movimientos de cada uno.
            left = leftResult.Item1;
            right = rightResult.Item1;
            int leftMovimientos = leftResult.Item2;
            int rightMovimientos = rightResult.Item2;

            // Fusionamos los arrays ordenados.
            var mergeResult = merge(left, right);

            // Obtenemos el array resultante y el número de movimientos de la fusión.
            result = mergeResult.Item1;
            int mergeMovimientos = mergeResult.Item2;

            // Calculamos el número total de movimientos.
            int totalMovimientos = leftMovimientos + rightMovimientos + mergeMovimientos;

            // Detenemos el Stopwatch y obtenemos el tiempo transcurrido.
            stopwatch.Stop();
            long tiemp = stopwatch.ElapsedMilliseconds;

            // Devolvemos el array ordenado, el número total de movimientos y el tiempo transcurrido.
            return (result, totalMovimientos, tiemp);
        }

        // Esta función fusiona dos arrays ordenados en un solo array ordenado.
        public (int[], int) merge(int[] left, int[] right)
        {
            // Inicializamos el número de movimientos a 0.
            int movimientos = 0;

            // Creamos el array result con la longitud total de los arrays left y right.
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            // Inicializamos los índices de los arrays left, right y result.
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            // Mientras queden elementos en alguno de los arrays...
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                // Si quedan elementos en ambos arrays...
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    // Si el elemento actual de left es menor o igual que el de right...
                    if (left[indexLeft] <= right[indexRight])
                    {
                        // Añadimos el elemento de left al array result y avanzamos los índices correspondientes.
                        result[indexResult] = left[indexLeft];
                        movimientos++;
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        // Si no, añadimos el elemento de right al array result y avanzamos los índices correspondientes.
                        result[indexResult] = right[indexRight];
                        movimientos++;
                        indexRight++;
                        indexResult++;
                    }
                }
                // Si solo quedan elementos en left...
                else if (indexLeft < left.Length)
                {
                    // Añadimos el elemento de left al array result y avanzamos los índices correspondientes.
                    result[indexResult] = left[indexLeft];
                    movimientos++;
                    indexLeft++;
                    indexResult++;
                }
                // Si solo quedan elementos en right...
                else if (indexRight < right.Length)
                {
                    // Añadimos el elemento de right al array result y avanzamos los índices correspondientes.
                    result[indexResult] = right[indexRight];
                    movimientos++;
                    indexRight++;
                    indexResult++;
                }
            }
            // Devolvemos el array resultante y el número de movimientos.
            return (result, movimientos);
        }
    }
}
