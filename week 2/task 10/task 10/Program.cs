using System;

class Program
{
    static void Main(string[] args)
    {
        float length;
        float area;

        Console.WriteLine("Enter Length:");
        length = float.Parse(Console.ReadLine());

        area = length * length;

        Console.WriteLine("The Area is: ");
        Console.Write(area);

        Console.ReadKey();
    }
}