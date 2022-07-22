// Показать кубы чисел, заканчивающихся на четную цифру (взял от 1 до N)

System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int cube = 1;
for (int i = 1; i <= N; i++)
{
    cube = i * i * i;
    if (cube % 2 == 0)
    {
        Console.WriteLine($"{i}^3=" + cube);
    }
}
