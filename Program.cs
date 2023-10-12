using System;

class Program
{
    static double Function(double x)
    {
        return x * Math.Cos(x) - 1;
    }

    static double BisectionMethod(double a, double b, double epsilon)
    {
        double c;

        while ((b - a) >= epsilon)
        {
            c = (a + b) / 2;

            if (Function(c) == 0.0)
                break;

            if (Function(c) * Function(a) < 0)
                b = c;
            else
                a = c;
        }

        return (a + b) / 2;
    }

    static void Main(string[] args)
    {
        double a, b, epsilon;

        Console.WriteLine("Введите границы интервала [a, b]:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите требуемую точность (epsilon):");
        epsilon = double.Parse(Console.ReadLine());

        double root = BisectionMethod(a, b, epsilon);

        Console.WriteLine("Корень уравнения: " + root);
    }
}