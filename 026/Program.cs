// Найти сумму чисел от 1 до А

int N=Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum = sum + i;
}
System.Console.WriteLine($" Сумма чисел от 1 до {N} = {sum}");