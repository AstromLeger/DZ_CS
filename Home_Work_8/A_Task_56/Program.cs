// Задание 56

Console.WriteLine("Количество строк должно быть больше как минимум на 1, чем количество столбцов!");
Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
int[] MassivSumm = new int[stroka];
Console.WriteLine("");
int Summ = 0;
int MinSumm = 0;
int StartI;

if (stroka == stolbez ^ stroka < stolbez)
{
    Console.WriteLine("Просим проверить зрение так как было указано:");
    Console.WriteLine("Количество строк должно быть больше как минимум на 1, чем количество столбцов!");
}
else
{
    FillMassiv();
    PrintMassiv();
    Console.WriteLine("");
    PodschetStrok();
    PrintMassiv1();
    Console.WriteLine("");
    Console.WriteLine(PoiskMinSumm(MinSumm) + 1 + " строка");
    Console.WriteLine("");
}





void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolbez; j++)
            Massiv[i, j] = new Random().Next(1, 10);

}


void PrintMassiv1()
{
    var str = string.Join(" ", MassivSumm);
    Console.WriteLine(str);
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


void PodschetStrok()
{
    for (int i = 0; i < stroka; i++)
    {
        StartI = i;
        PodschetSumStroki(StartI);
    }
}


void PodschetSumStroki(int StartI)
{
    Summ = 0;
    for (int j = 0; j < stolbez; j++)
    {
        Summ = Summ + Massiv[StartI, j];
    }
    MassivSumm[StartI] = Summ;
}


int PoiskMinSumm(int MinSumm)
{
    int min = MassivSumm[0];
    for (int i = 0; i < stroka; i++)
    {
        if (min > MassivSumm[i])
        {
            min = MassivSumm[i];
            MinSumm = i;
        }
    }
    return MinSumm;
}


























































































