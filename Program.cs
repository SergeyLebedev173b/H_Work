
// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
number = (number/10)%10;
Console.WriteLine(number);

// Задача 13: Напишите программу, которая выводит третью
//  цифру заданного числа или сообщает, что третьей цифры
//   нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if(number<100)
{
  Console.WriteLine("Третьей цифры нет");
}
  int number2 = (number)%10;
Console.WriteLine(number2);

// Задача 15: Напишите программу, которая принимает
//  на вход цифру, обозначающую день недели, и проверяет, 
//  является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("этот день не выходной");

 
