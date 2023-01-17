// Задание HARD SORT

Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
int PromPer = 0;
int StartI;
int StartJ;

FillMassiv();
PrintMassiv();
Raspredelenie();
Console.WriteLine("");
PrintMassiv();

void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolbez; j++)
            Massiv[i, j] = new Random().Next(1, 99);
        
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


void Raspredelenie()
{
    for (int i = 0; i < stroka; i++)
    {
       for (int j = 0; j < stolbez; j++)
       {
        StartI = i;
        StartJ = j;
        Massiv [i,j] = Sravnenie(StartI, StartJ);
       }
    }
}




int Sravnenie(int StartI, int StartJ)
{
    for (int i = StartI; i < stroka; i++)
    {
        for (int j = StartJ; j < stolbez; j++)
        {
            if (Massiv[StartI, StartJ] > Massiv[i, j])
            {
                PromPer = Massiv[StartI, StartJ];
                Massiv[StartI, StartJ] = Massiv[i, j];
                Massiv[i, j] = PromPer;
            }
        }
    }
    return Massiv [StartI, StartJ];
}























































































