Console.WriteLine("Введите первое число");
string nameA = Console.ReadLine();
int a = Convert.ToInt32(nameA);
Console.WriteLine("Введите второе число");
string nameB = Console.ReadLine();
int b = Convert.ToInt32(nameB);
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}