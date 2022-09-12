Console.WriteLine("Для уравнений y=k1*x+b1 и y=k2*x+b2 введите числа:");

Console.WriteLine("b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = ((b1-b2)/(k2-k1));
double y = (k2*b1-k1*b2)/(k2-k1);
if (k2==k1) Console.WriteLine("Прямые совпадают или параллельны");
else Console.WriteLine($"Точка пересечения прямых: ({(b1-b2)/(k2-k1)};{y})");