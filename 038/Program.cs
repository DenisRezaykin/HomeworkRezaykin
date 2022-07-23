// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N = 123;
int count=0;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(1, 500); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");

    for (int i = 0; i < array.Length; i++)
{
    if ( array[i]>=10 && array[i]<100)
    {
        count += 1;
    }
}
System.Console.Write($"\nВ одномерном массиве из 123 чисел элементов из отрезка [10,99] {count} элементов из отрезка [10,99]");
