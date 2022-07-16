// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.WriteLine("Введите число обозначающее день недели");
int a=Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 6:
        System.Console.WriteLine(a=6);
        System.Console.WriteLine("Выходной");
        break; 
    case 7:
        System.Console.WriteLine(a=7);
        System.Console.WriteLine("Выходной");
        break;
    default:
        System.Console.WriteLine("День недели не является выходным");
        break;
}


