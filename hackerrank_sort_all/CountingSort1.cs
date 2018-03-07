using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sort_all
{
    class CountingSort1
    {
        private static int MIN = 0;
        private static int MAX = 99;
        static int[] countingSort(int[] arr)
        {
            int[] res = new int[MAX+1];
            for(int i = 0; i <arr.Length; i++)
            {
                res[arr[i]]++;
            }

            return res;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = countingSort(arr);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}
