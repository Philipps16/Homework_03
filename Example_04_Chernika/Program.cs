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
        array[i] = rand.Next (1, 1000);
        Console.Write($"{array [i]}, ");
    }
}   
int x = 1;
int max_sum = 0;

while (x < (array.Length - 1))
{
    int sum = (array [x - 1] + array[x] + array [x + 1]);
    
    if (sum > max_sum)
    max_sum = sum;
    x++;

}

Console.Write ($"Максимальное количество ягод: {max_sum}");