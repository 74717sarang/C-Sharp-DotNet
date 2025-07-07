// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");

int[] arr = { 1,5,3,6,9,8,7};

Console.WriteLine("enter no:");
int no=int.Parse(Console.ReadLine());

Func(arr,no);
Class1 c = new Class1();
c.fun(arr);








void Func(int[] arr, int no)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[i] > arr[j])
            {
                int temp=arr[i];    
                arr[i]=arr[j];
                arr[j]=temp;

            }

        }
    }

    Console.WriteLine(arr[arr.Length-no]);
}