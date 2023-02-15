//Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите 2 числа");
string? Num1 = Console.ReadLine();
string? Num2 = Console.ReadLine();
if (Num1 != null && Num2 !=null)
{
    int NumLine1 = int.Parse(Num1);
    int NumLine2 = int.Parse(Num2);
    if((int)Math.Pow(NumLine2,2)==NumLine1)
    {
    Console.WriteLine($"Да, является второе число {NumLine2}, квадратом первого {NumLine1}");
    }
    else
    {
     Console.WriteLine($"Не является второе число {NumLine2}, квадратом первого {NumLine1}");   
    }

}
/////////////////////////////////////////////////
//Задача от Владимира.

Console.WriteLine("Введите 1 число");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
var number2 = Convert.ToInt32(Console.ReadLine());

if((int)Math.Pow(number2,2) == number1)
 {
    Console.WriteLine($"Да, является второе число {number2}, квадратом первого {number1}");
    }
    else
    {
     Console.WriteLine($"Не является второе число {number2}, квадратом первого {number1}");   
    }