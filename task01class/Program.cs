﻿// Напишите программу, которая принимает на вход координаты точки (X и Y)
// причем X не равно 0, Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка 

int InputNumber(string str) //ввод числа string - тип переменной, str - переменная //string (строка), bool, int[] целочисленный массив, double [] массив вещественных чисел,void(ничего не возвращает)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}  

int X = InputNumber("Введиде координату X: ");
int Y = InputNumber("Введиде координату Y: ");

// System.Console.Write("Введите координату X:  ");
// int X = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Y:  ");
// int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    System.Console.WriteLine("Номер четверти 1");
}
else if(X < 0 && Y > 0)
{
    System.Console.WriteLine("Номер четверти 2");
}
else if(X < 0 && Y < 0)
{
    System.Console.WriteLine("Номер четверти 3");
}   
else if(X > 0 && Y < 0)
{
    System.Console.WriteLine("Номер четверти 4");
}
else
{
    System.Console.WriteLine("Точка лежит в начале координат");
}