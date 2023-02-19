// Напишите программу, которая принимает на вход координаты точки (X и Y)
// причем X не равно 0, Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка 

int InputNumber(string str) //ввод числа string - тип переменной, str - переменная //string (строка), bool, int[] целочисленный массив, double [] массив вещественных чисел,void(ничего не возвращает)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void FindQuarter(int a, int b) //принимает две какие-то переменные
{
    if (a > 0 && b > 0)
{
    System.Console.WriteLine("Номер четверти 1");
}
else if (a < 0 && b > 0)
{
    System.Console.WriteLine("Номер четверти 2");
}
else if (a < 0 && b < 0)
{
    System.Console.WriteLine("Номер четверти 3");
}
else if (a > 0 && b < 0)
{
    System.Console.WriteLine("Номер четверти 4");
}
else
{
    System.Console.WriteLine("Точка лежит в начале координат");
}

}

FindQuarter(InputNumber("Введите координату X: "), InputNumber("Введите координату Y: "));

// int X = InputNumber("Введиде координату X: ");
// int Y = InputNumber("Введиде координату Y: ");

// FindQuarter(X, Y);
// FindQuarter(-4, 7);

// // System.Console.Write("Введите координату X:  ");
// // int X = Convert.ToInt32(Console.ReadLine());

// // System.Console.Write("Введите координату Y:  ");
// // int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     System.Console.WriteLine("Номер четверти 1");
// }
// else if (X < 0 && Y > 0)
// {
//     System.Console.WriteLine("Номер четверти 2");
// }
// else if (X < 0 && Y < 0)
// {
//     System.Console.WriteLine("Номер четверти 3");
// }
// else if (X > 0 && Y < 0)
// {
//     System.Console.WriteLine("Номер четверти 4");
// }
// else
// {
//     System.Console.WriteLine("Точка лежит в начале координат");
// }
