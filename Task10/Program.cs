//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

using System;
using static System.Console;

Clear();

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа это "+stringNumber[1]);

// Очень важный вопрос,надеюсь вы мне ответите. Я пытался сделать задачу закоментированным ниже способом, но в ответе постоянно выбивает нули, и я сам не могу разобраться почему.Надеюсь вы обьясните.
//Write("Type the three-digit number ");
//int number = Convert.ToInt32(ReadLine());
//WriteLine(number);
//int a1 = number/100/10;

//WriteLine($"{a1}");
//WriteLine(a1/100/10);
//Write($"Numer 2nd is a = {a1/100/10}");
// Три разных способа это сделать