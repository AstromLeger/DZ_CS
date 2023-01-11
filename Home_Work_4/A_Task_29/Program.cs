// Задание 29

int [] Massiv = new int [8];

int [] StrokaMassiv()
 {

    for (int i = 0; i < 8; i++)
    {
        int Number = i + 1;
        Console.WriteLine("Введите число" + Number);
        int x = Convert.ToInt32(Console.ReadLine());
        Massiv[i] = x;
    }

    return Massiv;
 }

   var str = string.Join(" ", StrokaMassiv());
   Console.WriteLine(str);