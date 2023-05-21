// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите чимсло 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чимсло 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
if (number1 < number2)
{
    Console.WriteLine($"Число {number2} больше числа {number1}");
}
else
{
    Console.WriteLine("Эти числа равны");
}