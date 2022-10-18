// Программа вычисляет корни квадратного уравнения.

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("----- Программа вычисляет корни квадратного уранения -----");
Console.WriteLine("-------------------- вида ax^2+bx+c=0 --------------------");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("                                                          ");
Console.Write("Введите a: ");
double a = Double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b = Double.Parse(Console.ReadLine());
Console.Write("Введите c: ");
double c = Double.Parse(Console.ReadLine());
double D = Math.Pow(b, 2)-4*a*c;
if (D < 0) Console.WriteLine("Уравнение не имеет корней");
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Корень уравнения {x}");
}
else
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"Первый корень уравнения {Math.Round(x1, 3)}");
    Console.WriteLine($"Второй корень уравнения {Math.Round(x2, 3)}");
}
Console.ReadKey();