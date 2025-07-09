using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    public class Zeroes
    {

        public static void leftMoveZeros(int[] arr)
        {
            int len=arr.Length;

            for (int i = arr.Length-1; i >=0; i--) {

                if (arr[i] != 0)
                {
                    arr[--len]=arr[i];
                }
            
            }
            while (len > 0)
            {
               arr[--len]=0;
            }
            //Console.WriteLine("Hii");


            foreach(var i in arr)
            {
                Console.Write(i+" ");
            }
        }

        internal static void rightshift(int[] arr)
        {
            int len = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] != 0)
                {
                    arr[len++]=arr[i];
                }
            }

            while (len < arr.Length)
            {
                arr[len++] = 0;

            }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
