using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public class BubbleSort
    {
        // Esta función implementa el algoritmo de ordenamiento Bubble Sort.
        public (int[], int, long) Bubble_sort(int[] vec)
        {
            // Iniciamos un Stopwatch para medir el tiempo que tarda el algoritmo.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Creamos una variable temporal para el intercambio de elementos y una variable para contar los movimientos.
            int temp = 0;
            int movimientos = 0;

            // Recorremos el array desde el principio hasta el penúltimo elemento.
            for (var i = 0; i < vec.Length - 1; i++)
            {
                // Creamos una variable booleana para saber si se ha realizado algún intercambio en esta pasada.
                bool mar = false;

                // Recorremos el array desde el principio hasta el penúltimo elemento.
                for (var j = 0; j < vec.Length - 1; j++)
                {
                    // Si el elemento actual es mayor que el siguiente...
                    if (vec[j] > vec[j + 1])
                    {
                        // Intercambiamos los elementos.
                        temp = vec[j];
                        vec[j] = vec[j + 1];
                        vec[j + 1] = temp;

                        // Marcamos que se ha realizado un intercambio y aumentamos el contador de movimientos.
                        mar = true;
                        movimientos++;
                    }
                }

                // Si no se ha realizado ningún intercambio en esta pasada, el array ya está ordenado.
                if (mar == false)
                {
                    // Detenemos el Stopwatch y devolvemos el array junto con el número de movimientos y el tiempo transcurrido.
                    stopwatch.Stop();
                    long tiempo = stopwatch.ElapsedMilliseconds;
                    return (vec, movimientos, tiempo);
                }
            }

            // Si hemos terminado todas las pasadas, detenemos el Stopwatch y devolvemos el array junto con el número de movimientos y el tiempo transcurrido.
            stopwatch.Stop();
            long tiemp = stopwatch.ElapsedMilliseconds;
            return (vec, movimientos, tiemp);
        }
    }
}
