// Подсчитать сумму цифр в числе
int sumCount(int N)
{
    int k = 0,
        sum = 0;
    while (N != 0)
    {
        k++;
        sum = sum + (N % 10);
        N = N / 10;
    }
    return sum;
}
System.Console.WriteLine(sumCount(501));
