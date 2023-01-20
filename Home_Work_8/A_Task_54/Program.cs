// Задание 54

Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
int StartI;
Console.WriteLine("");

FillMassiv();
PrintMassiv();
Console.WriteLine("");
Poraydok();
PrintMassiv();




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

void Poraydok()
{
    for (int i = 0; i < stroka; i++)
    {
        StartI = i;
        PoraydokVStroke(StartI);
    }
}


void PoraydokVStroke(int StartI)
{
    int PromPer = 0;
    for (int j = 0; j < stolbez; j++)
    {
        for (int i = j + 1; i < stolbez; i++)
        {
            if (Massiv[StartI, j] < Massiv[StartI, i])
            {
                PromPer = Massiv[StartI, j];
                Massiv[StartI, j] = Massiv[StartI, i];
                Massiv[StartI, i] = PromPer;
            }
        }
    }
}








//             // var str = string.Join(" ", Massiv);
//             // Console.WriteLine(str);
//             // Console.WriteLine("");



















































