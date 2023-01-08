// Задание 13
Console.WriteLine("Введите пожалуйста число");

string Number = Console.ReadLine();

if (Number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Number = Number.Substring(2, 1);
    Console.WriteLine(Number);
}




