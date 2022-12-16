// See https://aka.ms/new-console-template for more information
double a, b, square;
Console.WriteLine("Enter first number: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number: ");
b = Convert.ToDouble(Console.ReadLine());
square = b * b;
if (a == square)
{
    Console.WriteLine("A equals square B");
    Console.WriteLine("Square B is: "+square);
}
else
{
    Console.WriteLine("A isn't equals square B");
    Console.WriteLine("Square B is: "+square);
}