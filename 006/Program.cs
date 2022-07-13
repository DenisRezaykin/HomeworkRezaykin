// Написать программу вычисления значения функции y = sin(a). 

/*
double x,y;
x=3.1415; //x=Math.PI;
y=Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");
*/

//тип возвращаемого значения Имя_функции(аргументы функции)
double Sin(double x) //метод
{
    return Math.Sin(x);
}

double y=Sin(3.14);
System.Console.WriteLine(y);