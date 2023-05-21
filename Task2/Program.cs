// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 && number2 == number3)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Число {number1} самое большое");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Число {number2} самое большое");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"Число {number3} самое большое");
}
}


