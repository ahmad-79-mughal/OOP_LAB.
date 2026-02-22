using System;

class Program
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        double washingPrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toyCount = 0;
        double moneySaved = 0;
        int evenMoney = 0;
        int brotherCount = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0) 
            {
                evenMoney += 10;
                moneySaved += evenMoney;
                brotherCount++;
            }
            else 
            {
                toyCount++;
            }
        }

        double toyMoney = toyCount * toyPrice;
        moneySaved = moneySaved + toyMoney - brotherCount;

        if (moneySaved >= washingPrice)
        {
            Console.WriteLine("Yes! " + (moneySaved - washingPrice).ToString("F2"));
        }
        else
        {
            Console.WriteLine("No! " + (washingPrice - moneySaved).ToString("F2"));
        }

        Console.ReadKey();
    }
}