// Задача 4

Console.WriteLine("Введите цисло 1"); //здесь первое число
 int FirstТNumber = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите цисло 2"); //здесь второе число
 int SecondNumber = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите цисло 3"); //здесь третье число
 int ThirdNumber = Convert.ToInt32(Console.ReadLine());

if (FirstТNumber < SecondNumber && SecondNumber < ThirdNumber )
{
    Console.WriteLine(+ThirdNumber );
}
else if (FirstТNumber < SecondNumber && SecondNumber > ThirdNumber)
{
    Console.WriteLine(+SecondNumber );
}
else if (FirstТNumber > SecondNumber && SecondNumber > ThirdNumber)
{
    Console.WriteLine(+FirstТNumber );
}