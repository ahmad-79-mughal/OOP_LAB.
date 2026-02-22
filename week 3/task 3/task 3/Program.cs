using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int sum = 0;

        Console.WriteLine("Enter numbers (-1 to stop):");
        number = int.Parse(Console.ReadLine());

        while (number != -1)
        {
            sum += number;
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total Sum = " + sum);
        Console.ReadKey();
    }
}