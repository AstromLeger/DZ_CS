// Задача 34

Console.WriteLine("Введите число!");
int Number = Convert.ToInt32(Console.ReadLine());

int[] Massiv = new int[Number];
int KolOfPosNum = 0;

void FillMassiv(int[] Massiv)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        Massiv[i] = new Random().Next(100, 999);
    }
    var str = string.Join(" ", Massiv);
    Console.WriteLine(str);
}



int PodschetOfPositiveNumber(int[] Massiv, int KolOfPosNum)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        if (Massiv[i] % 2 == 0)
        {
            KolOfPosNum = KolOfPosNum + 1;
        }
    }
    return KolOfPosNum;
}


FillMassiv(Massiv);
Console.WriteLine(PodschetOfPositiveNumber(Massiv, KolOfPosNum));













