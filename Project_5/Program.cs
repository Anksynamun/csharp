﻿// See https://aka.ms/new-console-template for more information
int number;
Console.Write("Enter the number: ");
number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Last digit in entered number is: "+number % 10);