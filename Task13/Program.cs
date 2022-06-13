// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
using System;
using static System.Console;

Clear();

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(ReadLine());
WriteLine(number);

if (number <100) 
{
    WriteLine("Третьей цифры нет");
}
else
{
  for(;number>=1000; number/=10);
  WriteLine($"Третья цифра числа {number} - {number%10}");
}