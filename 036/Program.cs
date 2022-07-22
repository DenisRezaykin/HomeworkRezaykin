// Определить, присутствует ли в заданном массиве, некоторое число

// Инициализация массива
int N = 12;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-9, 10); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11

//Решение задачи
int f = 400;
array[3] = f;

// Вывод массива до обработки
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
System.Console.WriteLine();

// Линейный поиск
int j = 0;
while (j < array.Length && array[j] != f)
    j++;
if (j == array.Length)
    System.Console.WriteLine("\nNot found");
else
    System.Console.WriteLine($"\nElement {f} finded at {j}"); // \n означает переход на новую строчку
// Вывод результатов
