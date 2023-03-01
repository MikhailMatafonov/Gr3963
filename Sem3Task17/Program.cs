// Задача №17
// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой 
// находится эта точка.

//Метод читает данные от пользователя
//<тип> <имя метода> (<тип> <название переменной>)
// {
//     return <тип> (return - возвращаем)
// }
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод определяет четверть по координатам точки
void PrintQuuterTest(int x, int y)
{
    if(x>0 && y>0)Console.WriteLine("Точка в первой четверти");
    if(x>0 && y<0)Console.WriteLine("Точка во второй четверти");
    if(x<0 && y<0)Console.WriteLine("Точка в третьей четверти");
    if(x<0 && y>0)Console.WriteLine("Точка в четвертой четверти");
}

int coordX = ReadData("Введите координату x:");
int coordY = ReadData("Введите координату y:");

PrintQuuterTest(coordX,coordY);