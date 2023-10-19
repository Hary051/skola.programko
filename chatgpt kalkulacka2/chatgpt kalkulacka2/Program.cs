using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Extended Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exponentiation");
            Console.WriteLine("6. Root");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice (1/2/3/4/5/6/7): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 7)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                if (double.TryParse(Console.ReadLine(), out double num1))
                {
                    if (choice != 6)
                    {
                        Console.Write("Enter the second number: ");
                        if (double.TryParse(Console.ReadLine(), out double num2))
                        {
                            double result = 0;

                            switch (choice)
                            {
                                case 1:
                                    result = num1 + num2;
                                    break;
                                case 2:
                                    result = num1 - num2;
                                    break;
                                case 3:
                                    result = num1 * num2;
                                    break;
                                case 4:
                                    if (num2 != 0)
                                    {
                                        result = num1 / num2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error: Division by zero!");
                                        continue;
                                    }
                                    break;
                                case 5:
                                    result = Math.Pow(num1, num2);
                                    break;
                                case 6:
                                    Console.Write("Enter the root index: ");
                                    if (double.TryParse(Console.ReadLine(), out double rootIndex))
                                    {
                                        if (rootIndex != 0)
                                        {
                                            result = Math.Pow(num1, 1 / rootIndex);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Error: Root index cannot be zero.");
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input for the root index.");
                                        continue;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    continue;
                            }

                            Console.WriteLine("Result: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for the second number.");
                        }
                    }
                    else
                    {
                        if (num1 >= 0)
                        {
                            Console.Write("Enter the root index: ");
                            if (double.TryParse(Console.ReadLine(), out double rootIndex))
                            {
                                if (rootIndex != 0)
                                {
                                    double result = Math.Pow(num1, 1 / rootIndex);
                                    Console.WriteLine("Result: " + result);
                                }
                                else
                                {
                                    Console.WriteLine("Error: Root index cannot be zero.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for the root index.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Root of a negative number is undefined.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the first number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }
        }
    }
}
