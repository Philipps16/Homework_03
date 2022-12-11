Console.Clear ();

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 10000 || a > 99999)
{
    Console.Write("Попробуйте еще: ");
    a = Convert.ToInt32(Console.ReadLine());
}
string s = a.ToString();

char[] array = s.ToCharArray();

for (int i = 0; i < 3;)
{
    if (array[i] == array [(array.Length - 1)])
    {
    if (array[i+1] != array [(array.Length - 2)])
    Console.Write ("Число является палиндромом");
    break;
    }
    else
    Console.Write ("Число не является палиндромом");
    break;
}