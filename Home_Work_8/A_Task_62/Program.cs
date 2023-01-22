// Задание 62

Console.WriteLine("Числа должны быть одинаковыми!!!");
Console.WriteLine("Введите первое число");
int Colichstrok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Colichstolbzov = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[Colichstrok, Colichstolbzov];
int proiz = 0;


if (Colichstrok != Colichstolbzov)
{
    Console.WriteLine("Числа должны быть одинаковыми!!!");
}
else
{
    proiz = Colichstrok * Colichstolbzov;
    FillMassiv();
    PrintMassiv();
    Console.WriteLine("");
    ZapMasPoSpir();

    PrintMassiv();
}


void FillMassiv()
{
    for (int i = 0; i < Colichstrok; i++)
        for (int j = 0; j < Colichstolbzov; j++)
            Massiv[i, j] = 0;

}


void PrintMassiv()
{
    for (int i = 0; i < Colichstrok; i++)
    {
        for (int j = 0; j < Colichstolbzov; j++)
            Console.Write($"{Massiv[i, j]} ");
        Console.WriteLine();
    }
}



void ZapMasPoSpir()
{
    int stroka = 0;
    int stolbez = 0;
    int Cycle = 1;

    for (int i = 1; i <= proiz; i++)
    {
        Console.WriteLine(stroka);
        Console.WriteLine(stolbez);
        Console.WriteLine(i);
        Console.WriteLine("");
        Massiv[stroka, stolbez] = i;

        if (Cycle == 1)
        {
            if (stolbez + 1 > Colichstolbzov - 1 || Massiv[stroka, stolbez + 1] != 0)
            {
                Cycle = 2;
                stroka++;
            }
            else
            {
                stolbez++;
            }
        }
        else if (Cycle == 2)
        {
            if (stroka + 1 > Colichstrok - 1 || Massiv[stroka + 1, stolbez] != 0)
            {
                Cycle = 3;
                stolbez--;
            }
            else
            {
                stroka++;
            }
        }

        else if (Cycle == 3)
        {
            if (stolbez - 1 < 0 || Massiv[stroka, stolbez - 1] != 0)
            {
                Cycle = 4;
                stroka--;
            }
            else
            {
                stolbez--;
            }
        }

        else 
        {
            if (stroka - 1 < 0 || Massiv[stroka - 1, stolbez] != 0)
            {
                Cycle = 1;
                stolbez++;
            }
            else
            {
                stroka--;
            }
        }
    }
}














































































