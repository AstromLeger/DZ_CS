// Задание 15

Console.WriteLine("Введите число от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 1 ^ x > 7)
{
    Console.WriteLine("Неккоректное число");
}
else if (x == 6 ^ x == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}







