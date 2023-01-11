// Задание 27

Console.WriteLine("Введите число!");
int Number = Convert.ToInt32(Console.ReadLine());
int[] Massiv;


int Digit()
{
    int Number2 = Number;
    int NumberOfDigits = 0;
    while (Number2 / 10 > 0)
    {
        Number2 = Number2 / 10;
        NumberOfDigits = NumberOfDigits + 1;
    }
    return NumberOfDigits + 1;
}

int Digit1 = Digit();


Massiv = new int [Digit1];

// var str = $"{Digit1} {Number}";
// Console.WriteLine(str);


int Summ()
{
    for (int i = 0; i < Digit1; i++)
    {
        if (i == 0)
        {
            Massiv[i] = Number / Convert.ToInt32(Math.Pow(10, Digit1 - 1 - i));      
        }
        else
        {
            Massiv[i] = Number / Convert.ToInt32(Math.Pow(10, Digit1 - 1 - i));
            Massiv[i] = Massiv[i] % 10;
        }   
        // var str = string.Join(" ", Massiv);
        // Console.WriteLine(str);
    }

    

    int SummNum = 0;

    for (int i = 0; i < Digit1; i++)
    {
        SummNum = SummNum + Massiv[i];
    }
    return SummNum;
}

Console.WriteLine(Summ());















