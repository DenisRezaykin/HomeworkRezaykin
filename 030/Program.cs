// Написать программу вычисления произведения чисел от 1 до N
System.Console.WriteLine("Введите число N");
int N=Convert.ToInt32(Console.ReadLine());
int multiCount(int N)
{
    int k=1, multi = 1;
    while (k<=N)
    {
        multi = multi * k;
        k++;
    }
    return multi;
}

System.Console.WriteLine(multiCount(N));
