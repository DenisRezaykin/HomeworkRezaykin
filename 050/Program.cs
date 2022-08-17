// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] a;
a = Init(5, 6);

// Вывод массива на экран до обаботки
Print(a);

// Решение задачи

for (int i = 0; i < a.GetLength(0); i++) // (0) означает получить длину по нулевому измерению
{
    for (int j = 0; j < a.GetLength(1); j++) // (1) означает получить длину по первому измерению
    {
        if (a[i, j] % 2 == 0)
        {
            a[i, j] = -a[i, j];
        }
    }
}
System.Console.WriteLine();

// Вывод массива на экран после обаботки
Print(a);

// Подпрограмма

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j]} ");
        System.Console.WriteLine();
    }
}

int[,] Init(int n, int k)
{
    a = new int[n, k]; //создаем массив
    // инициализация случайными числами
    Random random = new Random(); // Создали объект типа Random

    for (int i = 0; i < a.GetLength(0); i++) // (0) означает получить длину по нулевому измерению
    {
        for (int j = 0; j < a.GetLength(1); j++) // (1) означает получить длину по первому измерению
        {
            a[i, j] = random.Next(1, 11);
        }
    }
    return a;
}
