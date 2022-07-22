// Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива

/* int N=12;
int[] array=new int[N];
for (int i = 0; i < array.Length; i++)
array[i]=i;
for (int i = 0; i < array.Length; i++)
System.Console.Write($"{array[i],4}"); //4 означает выделение 4 знаков после числа из массива
*/

// Рандомный массив

// Инициализация массива
int N = 12;
int[] array = new int[N];
Random random = new Random(); // псевдослучайные числа
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-9, 10); //Максимальное число надо брать на одно больше, например надо 10, а пишем 11

// Вывод массива до обработки
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 4} ");
    System.Console.WriteLine();

//Решение задачи
int sumPositive = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
        sumPositive = sumPositive + array[i]; // Можно заменить на sumPositive+=array[i]

int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] < 0)
        sumNegative = sumNegative + array[i]; //Можно заменить на sumNegative+=array[i]

// Вывод результатов
System.Console.WriteLine(sumPositive);
System.Console.WriteLine(sumNegative);
