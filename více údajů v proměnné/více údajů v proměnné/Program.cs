//// See https://aka.ms/new-console-template for more information
//using System.Globalization;

//Console.WriteLine("Hello, World!");

//void Printarray(int []numbers)
//{

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i]);

//    }
//    Console.WriteLine();


//}


//int[] number3 = { 1, 2, 3};
//Printarray(number3);

//int[] number4 = number3;
//Printarray(number3);
//Printarray(number4);

//number3[0] = 4;
//Printarray(number3);
//Printarray(number4);

int[] coeficients = new int[] { 6, 12, 5, 5, -4, 10 };

void Printbignumber(int[] coeficients)
{
 int o = coeficients.Length-1;
    for (int i = 0; i < coeficients.Length; i++)
    {
        
        Console.Write(coeficients[i]);

        Console.Write("x^"+o);
        if (i< coeficients.Length - 1)
        {
            Console.Write(" + ");
        }

        o = o - 1;
       
    } 
    Console.WriteLine();
}

Printbignumber(coeficients);
Printbignumber(coeficients);