// Задание 19

Console.WriteLine("Введите пожалуйста число!");
int PolymNumber = Convert.ToInt32(Console.ReadLine());
int NumberOfDigits = 5;
int[] Massiv = new int[NumberOfDigits];



for (int i = 0; i < NumberOfDigits; i++)
{
    if (i == 0)
    {
        Massiv[i] = PolymNumber / Convert.ToInt32(Math.Pow(10, NumberOfDigits - 1 - i));
         
    }
    else
    {
        Massiv[i] = PolymNumber / Convert.ToInt32(Math.Pow(10, NumberOfDigits - 1 - i));
        Massiv[i] = Massiv[i] % 10;
    }
    
}

var str = string.Join(" ", Massiv);
    Console.WriteLine(str);

bool Sovpadenie()
{
    bool LogPer = true;
for (int i = 0; i < 2; i++)
{
    if (Massiv[i] == Massiv[NumberOfDigits - i - 1])
    {
        LogPer = true;
    }
    else
    {
        LogPer = false;
    }
}
return LogPer ;
}
if (Sovpadenie())
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
















