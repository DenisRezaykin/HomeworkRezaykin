// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// Инициализация массива
int N = 8;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(0, 2); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11

// Вывод массива до обработки
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
