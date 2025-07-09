using MoveZeroes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] arr = { 9, 8, 7, 0, 5, 0, 3, 0 };
        //		Arrays.sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("leftShiift");
        Zeroes.leftMoveZeros(arr);
        Console.WriteLine();
        Console.WriteLine("Right shift");

        Zeroes.rightshift(arr);






    }

}



