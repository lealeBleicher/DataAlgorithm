using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Ex2
    {
        public static bool AreEquals(int [] arr1,int [] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            Dictionary<int, int> d = new Dictionary<int, int>();
            int c = 0;
            for(int i=0;i<arr1.Length;i++)
            {
                if (!d.ContainsKey(arr1[i]))
                    d.Add(arr1[i], 1);
                else
                {
                    c = d[arr1[i]]+1;
                    d.Remove(arr1[i]);
                    d.Add(arr1[i], c);
                }
            }
            for(int i=0;i<arr2.Length;i++)
            {
                if (!d.ContainsKey(arr2[i]))
                    return false;
                if (d[arr2[i]] == 0)
                    return false;
                c = d[arr2[i]]-1;
                if (!d.ContainsKey(arr2[i]))
                    d.Add(arr2[i], c);

            }
            return true;
        }
    }
}
