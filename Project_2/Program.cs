// See https://aka.ms/new-console-template for more information
double day;
Console.WriteLine("Введите номер дня недели: ");
day = Convert.ToDouble(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
if (day == 2)
{
    Console.WriteLine("Вторник");
}
if (day == 3)
{
    Console.WriteLine("Среда");
}
if (day == 4)
{
    Console.WriteLine("Четверг");
}
if (day == 5)
{
    Console.WriteLine("Пятница");
}
if (day == 6)
{
    Console.WriteLine("Суббота");
}
if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
if (day > 7)
{
    Console.WriteLine("Введён неверный параметр!");
}