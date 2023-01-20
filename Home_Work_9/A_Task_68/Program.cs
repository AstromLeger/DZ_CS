// Задача 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = " + FuncAkkerman(m, n));
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return FuncAkkerman(m - 1, 1) ;
    else
    return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}




























































































