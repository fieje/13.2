//Програма для обчислення математичного виразу
using System;

class Program
{
    static void Main(string[] args)
    {
        float x, y, z;
        float numerator, denominator, result;

        Console.WriteLine("Enter the value of x: ");
        x = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of y: ");
        y = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of z: ");
        z = float.Parse(Console.ReadLine());

        if (z > 10)
        {
            numerator = Math.Max((float)Math.Pow(x, 3), (float)Math.Pow((x + y), 2));
        }
        else
        {
            numerator = 0; 
        }

        if (z <= 10)
        {
            denominator = Math.Min(Math.Abs(x - 2), Math.Abs(x + z));
        }
        else
        {
            denominator = 1; 
        }

        if (denominator == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return;
        }

        result = numerator / denominator;

        Console.WriteLine("Result: " + result);
        Console.ReadLine();
    }
}

//x=2
//y=3
//z=12