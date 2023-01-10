// Задание 21

Console.WriteLine("Введите кординату x точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату y точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату z точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату x точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату y точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату z точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance;



Distance = Math.Sqrt (2 * Math.Pow(x1 - x2, 2) + 2 * Math.Pow(y1 - y2, 2) + 2 * Math.Pow(z1 - z2, 2) );

Console.WriteLine(Distance);









