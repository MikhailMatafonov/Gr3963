// Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.1


//Метод читает данные от пользователя
//<тип> <имя метода> (<тип> <название переменной>)
// {
//     return <тип> (return - возвращаем)
// }
int ReadInput(string num)
{
    Console.WriteLine(num);
    return int.Parse(Console.ReadLine()??"0");
}
string LineBuilder(int num, int pow)
{
    string result = String.Empty;
//    pow = 3;
    for (int i = 1; i <= num; i++) // "вводим ограничения"
        {
            result = (result + Math.Pow(i,pow+1)+"\t"); //вычисляем куб заданного числа
        }
    return result;
}
int N = ReadInput("Введите число: ");
Console.WriteLine(LineBuilder(N,1 - 1)); //выводим первую строку в консоли
Console.WriteLine(LineBuilder(N,2)); //выводим вторую строку в консоли