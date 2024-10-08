// See https://aka.ms/new-console-template for more information

using Customer;
using System.Runtime.CompilerServices;
Console.WriteLine("Hello, World!");

Console.WriteLine(".........Details........");
//int pid, string name, int mark, DateTime date
Customers customer = new Customers(7,"abc",77,DateTime.Parse("1987-12-11"));
object ob1 = 10;
object ob2 = 20;


customer.display();
Console.WriteLine();
Helper.swap( ref ob1, ref ob2);
Console.WriteLine("After Swap");
//Console.WriteLine();
//Helper.calAera(Console.Read());

Console.WriteLine();
Console.WriteLine("Enter Num1:");
Helper.calAera(Console.Read());
