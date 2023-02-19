// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y) 

// Напишите программу, которая принимает на вход координаты точки (X и Y)
// причем X не равно 0, Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка 

System.Console.Write("Введите номер четверти:  ");
int A = Convert.ToInt32(Console.ReadLine());

{
    if (A == 1)
{
    System.Console.WriteLine("x > 0, y > 0");
}
else if (A == 2)
{
    System.Console.WriteLine("x < 0, y > 0");
}
else if (A == 3)
{
    System.Console.WriteLine("x < 0, y < 0");
}
else if (A == 4)
{
    System.Console.WriteLine("x> 0, y < 0");
}
else 
{
    System.Console.WriteLine("такой четверти не существует");
}
}

// FindQuarter(InputNumber("Введите координату X: "), InputNumber("Введите координату Y: "));

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

