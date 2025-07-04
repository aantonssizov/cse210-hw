using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];

        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        int smallestPositive = numbers.Where(n => n > 0).Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}