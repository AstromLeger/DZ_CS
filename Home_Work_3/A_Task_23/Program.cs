// Зданаие 23

Console.WriteLine("Введите число!");
int x = Convert.ToInt32(Console.ReadLine());
int [] Massiv = new int [x];

var str1 = string.Join(" ", Massiv);
Console.WriteLine(str1);

for (int i = 0; i < x; i++)
{
   Massiv [i] = Convert.ToInt32(Math.Pow(i+1, 3));
}

var str = string.Join(" ", Massiv);
Console.WriteLine(str);













