// Найти сумму чисел одномерного массива стоящих на нечетной позиции

// Инициализация массива
int N = 12;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-12, 10); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11

// Вывод массива до обработки
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
System.Console.WriteLine("");

//Решение задачи
int s = 0;
for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
        s = s + array[i];
System.Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции равна {s}");
