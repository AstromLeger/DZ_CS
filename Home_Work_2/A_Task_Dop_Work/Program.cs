// Дополнительно задание

Console.WriteLine("Введите число");
int NumberOfProgrammers = Convert.ToInt32(Console.ReadLine());
// string NumberOfProgrammers = Console.ReadLine();
// int Number = NumberOfProgrammers.Substring (NumberOfProgrammers.Length, 1);

if (NumberOfProgrammers <0)
{
     Console.WriteLine("Некорректное число!!! Нельзя вводить отрицательное число!!!");
}
else if (NumberOfProgrammers <15 & NumberOfProgrammers >10 ) 
{
    Console.WriteLine(NumberOfProgrammers + " программистов");
}
else if (NumberOfProgrammers % 10 == 1)
{
    Console.WriteLine(NumberOfProgrammers + " программист");
}
else if (NumberOfProgrammers % 10 > 1 & NumberOfProgrammers % 10 < 5)
{
    Console.WriteLine(NumberOfProgrammers + " программиста");
}
else if (NumberOfProgrammers % 10 > 4 & NumberOfProgrammers % 10 < 10 ^ NumberOfProgrammers % 10 == 0 )
{
    Console.WriteLine(NumberOfProgrammers + " программистов");
}











