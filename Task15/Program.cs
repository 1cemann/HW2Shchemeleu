//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;
using static System.Console;

Clear();

Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(ReadLine());

if(dayNumber == 6 || dayNumber ==7)
{
    WriteLine("Этот день выходной");
}
else if(dayNumber < 1 || dayNumber > 7)
{
    WriteLine("Это вообще не день недели");
}
else
{
    WriteLine("Этот день не выходной");
}