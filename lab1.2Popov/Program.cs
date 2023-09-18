//средний 11

Console.WriteLine("Введите b");
double b = double.Parse(Console.ReadLine());
const float x = 2f;
double a = Math.Pow((b+x),3);
double c = Math.Log(Math.Abs(b));
double y=c*c+Math.Sqrt(Math.Abs(a));
Console.WriteLine($"y={y:F2}");



