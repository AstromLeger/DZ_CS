// Задание 25

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int Degree = Convert.ToInt32(Console.ReadLine());


int Exponentiation()
{

    int NumberInDegree = Number;
    // Первый вариант
    NumberInDegree = Convert.ToInt32(Math.Pow(Number, Degree));

    // Второй вариант
    // for (int i = 0; i < Degree; i++)
    // {
    //     NumberInDegree = Convert.ToInt32(Math.Pow(Number, i)) * Number;
    // }
    return NumberInDegree;
}

Console.WriteLine(Exponentiation());














