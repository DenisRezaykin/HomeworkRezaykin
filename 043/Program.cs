// Определить сколько чисел больше 0 введено с клавиатуры

//решение
System.Console.WriteLine(CountPositiveNumbers(Input())); 

//функции
int CountPositiveNumbers(int[] a) //функция подсчета чисел меньше 0
{
   int quantPosNumb=0;
   for (int i=0; i<a.Length; i++)
      if (a[i]>0) quantPosNumb++;
   return quantPosNumb;
}

int[] Input() //функция ввода: возвращает массив чисел введенных с клавиатуры
{
   string? s=Console.ReadLine();
   string[] ss=s.Split(' '); // создает массив из строки в которой разделителем для чисел служит пробел ' '
   int[] a=new int[ss.Length];
   for (int i=0; i<a.Length; i++)
   { 
      a[i]=int.Parse(ss[i]);  //перевод string в int
   }
   return a;
}
