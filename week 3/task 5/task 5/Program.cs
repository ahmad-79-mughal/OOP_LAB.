using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int largest = numbers[0];

        for (int i = 1; i < 3; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine("Largest number is: " + largest);
        Console.ReadKey();
    }
}