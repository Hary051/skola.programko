// See https://aka.ms/new-console-template for more information
using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        Console.WriteLine("Quadratic Equation Solver");
        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0)");

        // Prompt the user to enter coefficients a, b, and c
        while (true) { 
        Console.Write("Enter coefficient 'a': ");
        double a = double.Parse(Console.ReadLine());
        if(a == 0)
        {
                Console.Write("Nedávej nulu");

                continue;
        }
        Console.Write("Enter coefficient 'b': ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient 'c': ");
        double c = double.Parse(Console.ReadLine());
        
        // Calculate the discriminant (b^2 - 4ac)
        double discriminant = b * b - 4 * a * c;

        // Check the discriminant to determine the number of roots

        if (discriminant > 0)
        {
            // Two real and distinct roots
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine($"Root 1: {root1}");
            Console.WriteLine($"Root 2: {root2}");
                break;
        }
        else if (discriminant == 0)
        {
            // One real root (repeated root)
            double root = -b / (2 * a);
            Console.WriteLine($"Root: {root}");
                break;
        }
        else
        {
            Console.Write("rovnice nemá řešení ");
                break;
         }

        }
    }
}
