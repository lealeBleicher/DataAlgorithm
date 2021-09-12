using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class BinarySearch
    {
        public static int BSearch(int [] arr,int num,int l,int r)

        {
            if(l<=r)
            {
                int m =(l+r) / 2;
                if (arr[m] == num)
                    return m;
                if (arr[m] > num)
                    return BSearch(arr, num, l, m-1);
                else
                    return BSearch(arr, num, m + 1, r);
            }
            return -1;
        }
    }
}
