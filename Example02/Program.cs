// программа на нахождение расстояние между точками в 3D пространстве
Console.Clear();
Console.WriteLine("Введите координату X точки A:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A:");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B:");
int zb = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние от точки A до точки B в 3D пространстве= {distance}");