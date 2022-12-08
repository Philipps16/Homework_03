Console.Clear();

Console.WriteLine("Введите число");

int a = Convert.ToInt32 (Console.ReadLine ());
if (a < 0)
a = a * (-1);
int b = 0;
while (b < a)
{
    Console.Write ($"{Math.Pow (b, 3)}, ");
    b++;
}