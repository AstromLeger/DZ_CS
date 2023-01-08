// Задача 8

Console.WriteLine("Введите пожалуйста число ^_^");
int Number = Convert.ToInt32(Console.ReadLine());

 if (Number < 2) 
    {
    Console.WriteLine("Нет чётных чисел :(");
    }


for (int i = 2; i <= Number; i = i + 2)
{ 
    Console.WriteLine(+i);
}
