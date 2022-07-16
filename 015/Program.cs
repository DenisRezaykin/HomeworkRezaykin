// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
if (a / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {a} является цифра {a / 100 % 10}");
else System.Console.WriteLine($"У числа {a} нет третьей цифры");

