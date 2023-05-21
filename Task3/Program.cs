// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите чимсло: ");
int number = Convert.ToInt32(Console.ReadLine());
int div = number%2;
if (div == 0)
{
    Console.WriteLine($"Число {number} четное");
}
else
{
    Console.WriteLine($"Число {number} нечетное");
}