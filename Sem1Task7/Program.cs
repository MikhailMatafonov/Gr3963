//Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите 3 значное число");
string? numberN = Console.ReadLine();
if(numberN != null)
{
    int N = int.Parse(numberN);
    int res = N % 10;
    Console.WriteLine($"Последняя цифра {numberN} = {res}");
}

////////////////
Console.WriteLine("Введите 3 значное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100 && number < 1000)
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("Вы ввели не 3-х значное число");
}
