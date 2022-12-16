// See https://aka.ms/new-console-template for more information
double number;
Console.WriteLine("Введите число: ");
number = Convert.ToDouble(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}