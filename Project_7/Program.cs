// See https://aka.ms/new-console-template for more information
int number, fd, sd; // fd - first digit of number, sd - second digit
Console.Write("Enter the number: ");
number = int.Parse(Console.ReadLine()!);
fd = number / 10;
sd = number % 10;
if (fd > sd)
{
    Console.WriteLine("Max digit of entered number is: "+fd);
}
else
{
    Console.WriteLine("Max digit of entered number is: "+sd);
}