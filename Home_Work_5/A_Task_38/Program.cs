// Задание 38

Console.WriteLine("Введите число!");
int Number = Convert.ToInt32(Console.ReadLine());
double min;
double max;
double Raznica = 0;
bool vuzov;

double[] Massiv = new double[Number];


void FillMassiv(double[] Massiv)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        Massiv[i] = Math.Round((new Random().NextDouble()) * 100, 2, MidpointRounding.AwayFromZero);
    }
    var str = string.Join(" ", Massiv);
    Console.WriteLine(str);
}




double Sravnenie(bool vuzov, double[] Massiv)
{
// var str = string.Join(" ", Massiv);
//     Console.WriteLine(str);
    for (int i = 0; i < Massiv.Length; i++)
    {
        if (Massiv[i] > min)
        {
           if (Massiv[i] < max)
           {

           }
           else
           {
            max = Massiv[i];
           }
        }
        else 
        {
          min = Massiv[i];
        }

        // Console.WriteLine(min);
        // Console.WriteLine(max);
    }
    if (vuzov)
    {
        return min;
    }
    else
    {
        return max;
    }
}


FillMassiv(Massiv);
min = Massiv[0];
max = Massiv[0];
vuzov = true;
min = Sravnenie(vuzov, Massiv);
vuzov = false;
max = Sravnenie(vuzov, Massiv);
Raznica = max - min;


Console.WriteLine(Raznica);
