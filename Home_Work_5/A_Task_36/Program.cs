// Задание 36

Console.WriteLine("Введите число!");
int Number = Convert.ToInt32(Console.ReadLine());

int[] Massiv = new int[Number];
int SumOfOddNum = 0;

void FillMassiv(int[] Massiv)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        Massiv[i] = new Random().Next(1, 100);
    }
    var str = string.Join(" ", Massiv);
    Console.WriteLine(str);
}

int SummNumber(int[] Massiv, int SumOfOddNum)
{
    for (int i = 1; i < Massiv.Length; i = i + 2)
    {
        if (i % 2 > 0)   //сделал дополнительную проверку условия номера элемента (отрицательный или нет), хотя можно и без if из-за условия в for
        {
            SumOfOddNum = SumOfOddNum + Massiv[i];
        }
    }
    return SumOfOddNum;
}


FillMassiv(Massiv);
Console.WriteLine(SummNumber(Massiv, SumOfOddNum));







