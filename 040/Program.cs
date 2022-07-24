// Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// Инициализация массива
int N = 12;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(1, 11); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11

// Вывод массива до обработки
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
System.Console.WriteLine();

//Решение задачи
int[] b = new int[array.Length / 2];
for (int i = 0; i < array.Length / 2; i++)
    b[i] = array[i] * array[array.Length - i - 1];

// Вывод массива 
for (int i = 0; i < b.Length; i++)
    System.Console.Write($"{b[i], 4} ");
