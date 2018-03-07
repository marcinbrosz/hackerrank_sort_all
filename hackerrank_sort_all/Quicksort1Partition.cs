using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sort_all
{
    class Quicksort1Partition
    {
        static int[] quickSort(int[] arr)
        {
            int pivot = arr[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int[] res = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= pivot)
                    right.Add(arr[i]);
                if (arr[i] < pivot)
                    left.Add(arr[i]);
            }


            for(int i = 0; i < res.Count(); i++)
            {
                foreach (int a in left)
                {
                    res[i] = a;
                    i++;
                }

                    res[i] = pivot;
                    i++;
                

                foreach (int a in right)
                {
                    res[i] = a;
                    i++;
                }
            }
                
            

            return res;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = quickSort(arr);
            Console.WriteLine(String.Join(" ", result));


            Console.ReadLine();
        }
    }
}
