using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class BubbleSort
    {
        
        public static void bSort(int [] arr,int length)
        {
            int temp;
            bool sorted = false;
            for (int i=0; i<length ;i++)
            {
                if (sorted)
                    return;
                sorted = true;
                for(int j=0;j<length-i-1;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        sorted = false;
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
        }
    }
}
