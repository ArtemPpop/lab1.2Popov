
//1.1
//средний 11
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите n:");
double n = double.Parse(Console.ReadLine());
Console.Write("Введите D:");
double D = D = y * y * ((0.5 * n + 4.8) / (Math.Sin(y)));
Console.WriteLine($"{D:F2}");
//1.2
//средний 11

Console.WriteLine("Введите b");
double b = double.Parse(Console.ReadLine());
const float x = 2f;
double a = Math.Pow((b+x),3);
double c = Math.Log(Math.Abs(b));
double y=c*c+Math.Sqrt(Math.Abs(a));
Console.WriteLine($"y={y:F2}");



