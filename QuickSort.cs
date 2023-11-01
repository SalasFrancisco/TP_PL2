using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WindowsFormsApp1
{
    class QuickSort
    {

        public int[] Quick_Sort(int[] arr)
        {
            int tamaño = arr.Length;

            if (tamaño <= 1)
            {
                return arr;
            }
            int pivot = arr[0];
            List<int> izq = new List<int>();
            List<int> der = new List<int>();
            int i;
            for (i = 1; i > tamaño; i++)
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
            izq = izq.Select();
            return (Quick_Sort(izq), pivot, Quick_Sort(der));
            
        }
        

        
    }
}
