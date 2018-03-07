using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sort_all
{
    class Program
    {
        //print all steps
        static void Insertion_Sort(int[] ar)
        {
            List<string> res = new List<string>();
            int min = ar.LastOrDefault();
            for(int i = ar.Length-2; i >= 0; i--)
            {
                if (min < ar[i] )
                {
                    ar[i+1] = ar[i];
                    res.Add(string.Join(" ", ar));

                    if (i == 0)
                    {
                        ar[i] = min;
                        res.Add(string.Join(" ", ar));
                    }
                }
                else
                {
                    if (ar[i + 1] != min)
                    { 
                        ar[i + 1] = min;
                        min = ar[i];
                        res.Add(string.Join(" ", ar));
                    }else
                        min = ar[i];
                }
            }

            res.ForEach(Console.WriteLine);
        }

        //print only when find smaller
        static void Insertion_Sort2(int[] ar)
        {
            //for(int i = 1; i < res.Length; i++)
            //{
            //    for(int j = i - 1; j >= 0; j--)
            //    {
            //        if (res[j+1] < res[j])
            //        {
            //            int min = res[j+1];
            //            res[j+1] = res[j];
            //            res[j] = min;
            //        }
            //    }
            //}
            List<string> res = new List<string>();
            for (int i = 1; i < ar.Length; i++)
            {
                int i_temp = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ar[i_temp] < ar[j])
                    {
                        int min_temp = ar[i_temp];
                        ar[i_temp] = ar[j];
                        ar[j] = min_temp;
                        i_temp--;
                    }
                }
                res.Add(string.Join(" ", ar));
            }


            res.ForEach(Console.WriteLine);
        }

        //print only sorted ar
        static void Insertion_Sort3(int[] A)
        {
            //with for
            //List<string> res = new List<string>();
            //for (int i = 1; i < ar.Length; i++)
            //{
            //    int i_temp = i;
            //    for (int j = i - 1; j >= 0; j--)
            //    {
            //        if (ar[i_temp] < ar[j])
            //        {
            //            int min_temp = ar[i_temp];
            //            ar[i_temp] = ar[j];
            //            ar[j] = min_temp;
            //            i_temp--;
            //        }
            //    }
            //}
            //Console.WriteLine(string.Join(" ", ar.Select(x => x.ToString())));

            //with while
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
        static void Insertion_Sort4(int[] ar)
        {
            int count = 0;
            bool isChange = false;
            List<string> res = new List<string>();
            for (int i = 1; i < ar.Length; i++)
            {
                int i_temp = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ar[i_temp] < ar[j])
                    {
                        int min_temp = ar[i_temp];
                        ar[i_temp] = ar[j];
                        ar[j] = min_temp;
                        i_temp--;
                        count++;
                    }
                }


                isChange = false;


            }


            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            //simple search

            //int V = 0;
            //int n = 0;
            //V = Convert.ToInt32(Console.ReadLine());
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] ar = new int[n];
            //ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //int res = Array.IndexOf(ar, V);

            //Console.WriteLine(res);
            //const int n = 5;
            int[] ar = new int[] { 2 ,1, 3, 1, 2 };
            //int n = 0;
            //n =Convert.ToInt32( Console.ReadLine());
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //Console.WriteLine();
            Insertion_Sort4(ar);

            Console.Read();
        }
    }
}
