// Задача 52

Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
double[] Massiv1 = new double[stolbez];
double SredAriph = 0;
Console.WriteLine("");


FillMassiv();
PrintMassiv();
Console.WriteLine("");
SredAriphStolbza();
PrintMassiv1(Massiv1);





void FillMassiv()
{
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolbez; j++)
            Massiv[i, j] = new Random().Next(1, 10);

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


void SredAriphStolbza()
{
    for (int j = 0; j < stolbez; j++)
    {
        for (int i = 0; i < stroka; i++)
        {
            SredAriph = SredAriph + Massiv[i, j];
        }
        SredAriph = SredAriph / stroka;
        Massiv1[j] = SredAriph;
        SredAriph = 0;
    }
}


void PrintMassiv1(double [] Massiv1)
{
    for (int j = 0; j < stolbez; j++)
        Console.Write($"{Massiv1[j]} ");
    Console.WriteLine();
}



























































































