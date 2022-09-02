Console.WriteLine("Введите число");
string nameA = Console.ReadLine();
int a = Convert.ToInt32(nameA);
if (a % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}