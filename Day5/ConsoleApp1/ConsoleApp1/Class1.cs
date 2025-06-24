using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {

        public Class1() {
            Console.WriteLine("HIi by");
        }


        public static int large(int[] arr)
        {
            int l = arr[0];
            int secl = arr[0];

            int min=arr[0];
            int secMin=arr[0];
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > l)
                {
                    secl = l;
                    l= arr[i];  
                }
                else if(arr[i] > secl && arr[i] < l)
                {
                    secl= arr[i];
                }


                else if (arr[i] < min)
                {
                    secMin = min;
                    min= arr[i];
                }
                else if(arr[i] < secMin && arr[i] > min)
                {
                    secMin= arr[i];
                }
            }
            return secMin;
        }



        
    }
}
