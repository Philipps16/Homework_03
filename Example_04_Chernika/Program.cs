Console.Clear();

Console.WriteLine("Введите количество кустов");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 3 || n > 1000)
{
    Console.WriteLine ("Количество кустов должно быть больше 3 и менее 1000. Попробуйте еще раз.");
    n = Convert.ToInt32(Console.ReadLine());
}

    
int[] array = new int [n];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    {
        array[i] = rand.Next (0, 10);
        Console.Write($"{array [i]}, ");
    }
}   
int x = 1;
int max_sum = 0;

while (x < (array.Length - 1))
{

    {
        for (int y = 0; y < array.Length; y++)
        {
            if (y == 0)
            {
                int sum1 = (array [array.Length - 1] + array[y] + array [y + 1]);
                if (sum1 > max_sum)
                max_sum = sum1;
            }
                else if (y == (array.Length - 1))
                {
                    int sum2 = (array [0] + array[y] + array [y - 1]);
                    if (sum2 > max_sum)
                    max_sum = sum2;
                }
        }
    int sum = (array [x - 1] + array[x] + array [x + 1]);
    if (sum > max_sum)
    max_sum = sum;
    x++;
    }
}


Console.Write ($"Максимальное количество ягод: {max_sum}");