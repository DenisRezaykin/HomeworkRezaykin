// Написать программу вычисления произведения чисел от 1 до N
System.Console.WriteLine("Введите число N");
int N=Convert.ToInt32(Console.ReadLine());
int multiCount(int N)
{
    if (N==0) return 1;
    int k=0, sum = 1;
    while (N != 0)
    {
        k++;
        sum = sum * (N % 10);
        N = N / 10;
    }
    return sum;
}

System.Console.WriteLine(multiCount(N));
