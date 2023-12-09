using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Calculator: Please input 3 numbers for the average");

int number01;
Console.Write("Integer 1:");
number01 = Convert.ToInt32(Console.ReadLine() );

int number02;
Console.Write("Integer 2:");
number02 = Convert.ToInt32(Console.ReadLine() );

int number03;
Console.Write("Integer 3:");
number03 = Convert.ToInt32(Console.ReadLine() );




int average = (number01 + number02 + number03) / 3;

Console.WriteLine("Your average is: " + average);

Console.ReadKey();
