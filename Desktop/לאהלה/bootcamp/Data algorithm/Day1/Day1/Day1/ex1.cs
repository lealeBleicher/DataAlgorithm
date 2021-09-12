using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class ex1
    {
        public static void ThreeBig(int[] arr)
        {

            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (d.ContainsKey(arr[i]))
                    d[arr[i]]++;
                else
                    d.Add(arr[i], 1);
            }
            Tuple<int, int> t1 = new Tuple<int, int>(0, int.MinValue);
            Tuple<int, int> t2 = new Tuple<int, int>(0, int.MinValue);
            Tuple<int, int> t3 = new Tuple<int, int>(0, int.MinValue);

            foreach (var item in d)
            {
                if (item.Value > t1.Item2)
                {
                    t3 = t2;
                    t2 = t1;
                    t1 = new Tuple<int, int>(item.Key, item.Value);
                }
                else if (item.Value > t2.Item2)
                {
                    t3 = t2;
                    t2 = new Tuple<int, int>(item.Key, item.Value);
                }
                else if (item.Value > t3.Item2)
                    t3 = new Tuple<int, int>(item.Key, item.Value);


            }
            Console.WriteLine("first: " + t1.Item1 + " second: " + t2.Item1 + " third: " + t3.Item1);


        }
    }
}
