// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели и узнайте является ли он выходным ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7) Console.WriteLine("Ошибка, в неделе 7 дней");

if (num <= 5)
  Console.WriteLine($"{num} -> будний день ");

if (num == 6)
  Console.WriteLine($"{num} -> выходной день ");

if (num == 7)
  Console.WriteLine($"{num} -> выходной день ");

