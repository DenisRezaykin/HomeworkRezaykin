// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int N = 20;
int k=0;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(101, 200); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
for (int i = 0; i < array.Length; i++)
{
    if ( array[i] % 2 == 0)
    {
        k += 1;
    }
}
System.Console.Write($"\nВ массиве {k} четных чисел и {N-k} нечетных");