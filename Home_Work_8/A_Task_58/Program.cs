// Задание 58

Console.WriteLine("Введите количество строк для массивов");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для массивов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv1 = new int[stroka, stolbez];
int[,] Massiv2 = new int[stroka, stolbez];
int[,] ProizvedMassiv = new int[stroka, stolbez];
int SummProiz = 0;
Console.WriteLine("");


FillMassiv(Massiv1);
PrintMassiv(Massiv1);
Console.WriteLine("");
FillMassiv(Massiv2);
PrintMassiv(Massiv2);
Console.WriteLine("");
ProizvedenieMassivov();
PrintMassiv(ProizvedMassiv);
Console.WriteLine("");


void FillMassiv(int[,] Massiv)
{
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolbez; j++)
            Massiv[i, j] = new Random().Next(1, 10);

}


void PrintMassiv(int[,] Massiv)
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
            Console.Write($"{Massiv[i, j]} ");
        Console.WriteLine();
    }
}


void ProizvedenieMassivov()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
        {
            ProizvedMassiv[i, j] = Proizvedenie(i, j);

        }
    }
}


int Proizvedenie(int I, int J)
{


    SummProiz = 0;
    for (int j = 0; j < stolbez; j++)
    {
        // Console.WriteLine(J);
        // Console.WriteLine(j);
        SummProiz = SummProiz + Massiv1[I, j] * Massiv2[j, J];
        // Console.WriteLine(SummProiz);
    }
    return SummProiz;
}
































































































