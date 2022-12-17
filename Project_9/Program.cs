// See https://aka.ms/new-console-template for more information
int fn, sn, remainder; // fn - first number, sn - second number
Console.Write("Enter first number: ");
fn = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
sn = int.Parse(Console.ReadLine()!);
remainder = fn % sn;
if (remainder == 0)
{
    Console.WriteLine("The number is multiple");
}
else
{
    Console.WriteLine("The number is not multiple. The remainder is: " + remainder);
}