using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {


       public void fun(int[] arr)
        {
            Console.WriteLine("new ");
            int max = arr[0];
            int secMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secMax = max;
                    max = arr[i];
                }
                else if (max < arr[i] && arr[i] > secMax)
                {
                    secMax = arr[i];
                }
            }
            Console.WriteLine(secMax);
        }
    }
}
