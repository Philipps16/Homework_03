Console.Clear();

Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
if ((x1 == 0 && y1 == 0) || (x1 == 0 && z1 == 0) || (y1 == 0 && z1 == 0))
{
    Console.Write("Минимум 2 координаты не должны равняться 0. Попробуйте еще раз: ");
    Console.Write("Введите координату X первой точки: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Y первой точки: ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Z первой точки: ");
    z1 = Convert.ToDouble(Console.ReadLine());
}

Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
if ((x2 == 0 && y2 == 0) || (x2 == 0 && z2 == 0) || (y2 == 0 && z2 == 0))
{
    Console.Write("Минимум 2 координаты не должны равняться 0. Попробуйте еще раз: ");
    Console.Write("Введите координату X второй точки: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Y второй точки: ");
    y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Z второй точки: ");
    z2 = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))), 2));