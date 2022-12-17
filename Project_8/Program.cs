// See https://aka.ms/new-console-template for more information
int number, fd, td, fn; // fd - first digit of entered number, td - third digit, fn - final number
Console.Write("Enter the number: ");
number = int.Parse(Console.ReadLine()!);
fd = number / 100 % 10;
td = number % 10;
fn = int.Parse(fd.ToString() + td.ToString());
Console.WriteLine("Final number is: " + fn);