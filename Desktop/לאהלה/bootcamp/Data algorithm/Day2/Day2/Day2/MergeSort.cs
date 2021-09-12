using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class MergeSort
    {
        public static void Merge(int []arr,int l,int m,int r)
        {
            int size1 = m - l + 1;
            int size2 = r - m;
            int[] L = new int[size1];
            int[] R = new int[size2];
            int i, j;
            for (i = 0; i < size1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < size2;++j)
                R[j] = arr[m + 1 + j];
            i = 0;
            j = 0;
            int k = l;
            while(i<size1 && j<size2)
            {
                if(L[i]<=R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while(i<size1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < size2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

        }
        public static void sort(int []arr,int l,int r)
        {
            if(l<r)
            {
                int m = l + (r-l) / 2;
                sort(arr, l, m );
                sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
    }
}
