using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;

        do
        {
            Console.WriteLine("Enter number (-1 to stop):");
            number = int.Parse(Console.ReadLine());

            if (number != -1)
            {
                sum += number;
            }

        } while (number != -1);

        Console.WriteLine("Total Sum = " + sum);
        Console.ReadKey();
    }
}