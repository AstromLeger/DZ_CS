// Задание 50

Console.WriteLine("Введите количество строк");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stolbez = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int[stroka, stolbez];
Console.WriteLine("Введите число которое хотите найти");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
bool Sovpadenie = false;

FillMassiv();
PrintMassiv();
Console.WriteLine("");
Poisk();





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


void Poisk()
{
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbez; j++)
        {
            if (Massiv[i,j] == Number)
            {
                Sovpadenie = true;
                Console.WriteLine($"{i}, {j}");
            }
            // else
            // {
            //     Console.WriteLine("Такого числа нет");
            // }
        }
    }
    if (Sovpadenie)
    {

    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}



























































































