//Напишите программу, которая на вход принимает число (N) и на
//выходе показывает все четные числа от 1 до N. (Например 8 -> 2,4,6,8).
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i=i+2)
{
    Console.Write(i+"\t");
}