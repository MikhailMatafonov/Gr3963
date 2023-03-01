// Напишите программу, которая принимает на вход число 
//и проверяет кратное ли оно одновременно 7 и 23.
Console.Write("Введите число: ");
int Num1 = int.Parse(Console.ReadLine()??"0");
int Num2 = 7;
int Num3 = 23;
if(Num1%Num2==0 && Num1%Num3==0)
{
    Console.WriteLine($"Число {Num1} кратно {Num2} и {Num3}");
}
else
{
    Console.WriteLine($"Число {Num1} не кратно {Num2} и {Num3}");
}
// Решение через Тернарный оператор:

Console.WriteLine((Num1%Num2==0)?$"Число {Num1} кратно {Num2}":$"Число {Num1} не кратно {Num2}");
Console.WriteLine((Num1%Num3==0)?$"Число {Num1} кратно {Num3}":$"Число {Num1} не кратно {Num3}");

// Через bool:
bool oper = (Num1%Num2==0 && Num1%Num3==0);
if(oper)
{
    Console.WriteLine($"Число {Num1} кратно {Num2} и {Num3}");
}
else
{
    Console.WriteLine($"Число {Num1} не кратно {Num2} и {Num3}");
}