// Написать программу копирования массива
/*
// Инициализация массива
int[] a;
Init(out a, 12, -9, 9);

// Вывод массива до обработки
Print(a);

//Решение задачи
int[] b;
b=(int[])a.Clone();

// Вывод результатов
System.Console.WriteLine();
Print(b);


// Подпрограммы
void Init(out int[] t, int Length, int min, int max)
{
    t = new int[8];
    Random random = new Random();
    for (int i = 0; i < t.Length; i++)
        t[i] = random.Next(min, max + 1);
}

void Print(int[] t)
{
    for (int i = 0; i < t.Length; i++)
        System.Console.Write($"{t[i], 4} ");
}

*/
// 2 вариант решения, простой

// Инициализация массива
int[] a;
Init(out a, 12, -9, 9);

// Вывод массива до обработки
Print(a);

//Решение задачи
int[] b;
Clone(a, out b);

// Вывод результатов
System.Console.WriteLine();
Print(b);

// Подпрограммы
void Clone(int[] a, out int[] b)
{
    b = new int[a.Length];
    for (int i = 0; i < a.Length; i++)
        b[i] = a[i];
}

void Init(out int[] t, int Length, int min, int max)
{
    t = new int[8];
    Random random = new Random();
    for (int i = 0; i < t.Length; i++)
        t[i] = random.Next(min, max + 1);
}

void Print(int[] t)
{
    for (int i = 0; i < t.Length; i++)
        System.Console.Write($"{t[i], 4} ");
}
