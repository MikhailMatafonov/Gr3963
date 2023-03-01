// Задача 22
// Напишите программу, котора принимает на вход  число (N),
// и выдаёт таблицу квадратов чисел от 1 до N.

// Console.WriteLine("Введите число");
int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine()??"0");
}
string LineBuilder(int num, int pow)
{
    string result = String.Empty;
    for (int i = 1; i <= num; i++)
        {
            result = result + Math.Pow(i,pow)+"\t";
        }
    return result;
}
int N = ReadInput("Введите конечное число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));