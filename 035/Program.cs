// Написать программу замены элементов массива на противоположные

// Инициализация массива
int N = 12;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-12,10); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11

// Вывод массива до обработки
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
    System.Console.WriteLine("");

//Решение задачи
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1); // Можно заменить на sumPositive+=array[i]
    System.Console.Write($"{array[i], 4} ");
}
