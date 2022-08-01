// Задать массив из 8 целых элементов и вывести их на экран
/*
int[] t; // объявление
t = new int[8];
t[0] = 10;
t[1] = 12;

// инициализация
for (int i = 0; i < t.Length; i++)
    t[i] = i * 10;
//решение задачи

//вывод результатов на экран
for (int i = 0; i < t.Length; i++)
    System.Console.Write($"a[{i}]={t[i]} ");
*/
// Задать массив из 8 целых элементов и вывести их на экран (с использованием подпрограммы)

int[] t;
Init(out t,8,0,10);
Print(t, "t");

void Init(out int [] t, int Length, int min, int max)
{
    t = new int[8];
    Random random=new Random();
    for (int i = 0; i < t.Length; i++)
    t[i] = random.Next(min,max+1);
}

void Print (int [] t, string variableName)
{
    for (int i = 0; i < t.Length; i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
}