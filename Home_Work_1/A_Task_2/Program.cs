// Задача №2
Console.WriteLine("Введите число 1"); //здесь первое числ
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2"); //здесь второе число

int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber < SecondNumber )
{
    Console.WriteLine("min = " +FirstNumber + ", max = " +SecondNumber );
}
else
{
    Console.WriteLine("min = " +SecondNumber + ", max = " +FirstNumber  );
}