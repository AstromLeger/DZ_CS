// Задание 47

Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
double[,] Massiv = new double[stroka, stolbez];

FillMassiv();
PrintMassiv();






void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
        {
            Massiv[i,j] = Math.Round((new Random().NextDouble()) * 100, 2, MidpointRounding.AwayFromZero);
            if (new Random().Next(1, 99) > 49)
            {
                Massiv [i,j] = Massiv[i,j] * -1;
            }
        }    
    }
}

void PrintMassiv()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
            Console.Write($"{Massiv[i, j]} ");
            Console.WriteLine();
    }
}


























































































