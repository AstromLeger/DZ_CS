// Задание 41

Console.WriteLine("Сколько чисел вы хотите ввести?");
int AmOfNum = Convert.ToInt32(Console.ReadLine());
int[] Massiv = new int[AmOfNum];
int PolNum = 0;

for (int i = 0; i < AmOfNum; i++)
{
    Console.WriteLine("Введите пожалуйста число " + (i+1));
    Massiv[i] = Convert.ToInt32(Console.ReadLine());
}

// var str = string.Join(" ", Massiv);
//     Console.WriteLine(str);

int ColPolNum()
{
    for (int i = 0; i < AmOfNum; i++)
    {
        if (Massiv[i]>0)
        {
            PolNum = PolNum + 1;
        }
    }
    return PolNum;
}

Console.WriteLine(ColPolNum());
































