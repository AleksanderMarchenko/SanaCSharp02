﻿int number;
do
{
    Console.Write($"Enter the number from 0 to 9 -  ");
    number = int.Parse(Console.ReadLine());
    switch (number)
    {
        case 0:
            Console.WriteLine("zero");
            break;
        case 1:
            Console.WriteLine("one");
            break;
        case 2:
            Console.WriteLine("two");
            break;
        case 3:
            Console.WriteLine("three");
            break;
        case 4:
            Console.WriteLine("for");
            break;
        case 5:
            Console.WriteLine("five");
            break;
        case 6:
            Console.WriteLine("six");
            break;
        case 7:
            Console.WriteLine("seven");
            break;
        case 8:
            Console.WriteLine("eight");
            break;
        case 9:
            Console.WriteLine("nine");
            break;
        default:
            Console.WriteLine("Error!");
            break;
    }
}
while (Console.ReadKey().Key != ConsoleKey.Spacebar); 

