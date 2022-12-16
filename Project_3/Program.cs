// See https://aka.ms/new-console-template for more information
double a, b, c, max;
Console.WriteLine("Enter first number: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter third number: ");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Max number is: ");
max = Math.Max(a, Math.Max(b, c));
Console.WriteLine(max);