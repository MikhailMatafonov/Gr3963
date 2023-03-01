// Напишите программу, которая принимает на вход 2 числа 
//и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int NumOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int NumTwo = int.Parse(Console.ReadLine()??"0");
Console.WriteLine((NumOne*NumOne==NumTwo)? $"Первое число {NumOne} является квадратом второго {NumTwo}": $"Первое число {NumOne} не является квадратом второго {NumTwo}");
Console.WriteLine((NumTwo*NumTwo==NumOne)? $"Второе число {NumTwo} является квадратом первого {NumOne}": $"Второе число {NumTwo} не является квадратом первого {NumOne}");

//
void SqueraTest(int NumOne, int NumTwo)
{
if(NumOne==Math.Pow(NumTwo,2))
    {
        Console.WriteLine($"Число первое {NumOne} квадрат числа {NumTwo} ");
    }
    else
    {
        Console.WriteLine($"Число первое {NumOne} не квадрат числа {NumTwo} "); 
    }
}
SqueraTest(NumOne,NumTwo);
SqueraTest(NumTwo,NumOne);