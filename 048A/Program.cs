// Создать массив целых чисел NxM и заполнить его целыми случайными числами от 1 до 30. Вывести массив на экран

int N = 5;
int M = 4;

int[,] a = new int[N, M]; //описываем и создаем массив

// Инициализация случайными числами
Random random = new Random(); // Создали объект типа Random

for (int i = 0; i < a.GetLength(0); i++) // (0) означает получить длину по нулевому измерению
{
    for (int j = 0; j < a.GetLength(1); j++) // (1) означает получить длину по первому измерению
    {
        a[i, j] = random.Next(1, 11);
    }
}

// Вывод массива на экран
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
        System.Console.Write($"{a[i, j]} ");
    System.Console.WriteLine();
}