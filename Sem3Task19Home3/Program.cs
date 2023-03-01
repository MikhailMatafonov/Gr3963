// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
bool PalinTest(int Num)
{
    bool res = false;
    Console.WriteLine($"Введенное число {Num} не является Палиндромом ");
    if((Num/10000 == Num%10)&&(Num/1000)%10 == (Num/10)%10) //(сравниваем первое число и последнее) и (сравниваем второе число и предпоследнее)
    {
        res = true;
        Console.WriteLine($"Введенное число {Num} является Палиндромом ");
    }
    return res;
} 
int N = ReadData("Введите пятизначное число: ");
Console.WriteLine(PalinTest(N));

//Сделать вариант через СЛОВАРЬ четырёхзначных палиндромов...
//Dictionary <int bool>
//1221 true