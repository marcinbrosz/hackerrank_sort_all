using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sort_all
{
    class TheFullCountingSort
    {
        //for first solution
        static void theFullCountingSort(Dictionary<int,List<string>> map)
        {
            int[] count = new int[100];
            foreach(KeyValuePair<int, List<string>> m in map)
                count[m.Key]=m.Value.Count();

            for(int i = 0; i < count.Length; i++)
                for(int j = 0; j < count[i]; j++)
                    Console.Write(map[i][j]+" ");

        }
        static void Main(String[] args)
        {
            ////first solution with dictonary
            //int n = Convert.ToInt32(Console.ReadLine());
            //Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();
            //for (int a0 = 0; a0 < n; a0++)
            //{
            //    string[] tokens_x = Console.ReadLine().Split(' ');
            //    int x = Convert.ToInt32(tokens_x[0]);
            //    string s = tokens_x[1];

            //    if (a0 < n / 2)
            //        s = "-";

            //    if (map.ContainsKey(x))
            //        map[x].Add(s);
            //    else
            //        map.Add(x, new List<string> { s });
            //}
            //theFullCountingSort(map);
            //Console.ReadLine();

            ////secend solution with one for
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ar = new string[n];
            //for (int a0 = 0; a0 < n; a0++)
            //{
            //    string[] tokens_x = Console.ReadLine().Split(' ');
            //    int x = Convert.ToInt32(tokens_x[0]);
            //    string s = tokens_x[1];

            //    if (a0 < n / 2)
            //        ar[x] = ar[x]+" - ";
            //    else
            //        ar[x] = ar[x]+ s + " ";

            //}

            //foreach (string s in ar)
            //    Console.Write(s);

            //Console.ReadLine();

            //another solution
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();
            int[] res = new int[100];
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                string s = tokens_x[1];
                res[x]++;

                if (a0 < n / 2)
                    s = "-";

                if (map.ContainsKey(x))
                    map[x].Add(s);
                else
                    map.Add(x, new List<string> { s });
            }
            for(int i = 0; i < res.Count(); i++)
                for(int j = 0; j <res[i]; j++)
                    Console.Write(map[i][j] + " ");

            Console.ReadLine();


        }
    }
}
