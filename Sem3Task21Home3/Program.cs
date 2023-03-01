// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string num)
{
    Console.WriteLine(num);
    return int.Parse(Console.ReadLine()??"0");
}
//Метод выдает данные пользователя
void PrintData(string num, double val)
{
    Console.WriteLine(num + val);
}
//Метод находит расстояние между точками на плоскости
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
//  return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y1 - y2),2)) + Math.Pow((z2 - z1),2))); альтернативный пример
}

int x1 = ReadData("Введите координату x точки A:");
int y1 = ReadData("Введите координату y точки A:");
int z1 = ReadData("Введите координату z точки A:");
int x2 = ReadData("Введите координату x точки B:");
int y2 = ReadData("Введите координату y точки B:");
int z2 = ReadData("Введите координату z точки B:");

double res = CalcLen3D(x1, x2, y1, y2, z1, z2); //выводим результат, передаем полученные данные

PrintData("Растояние между точками A и B = ", res);

//Сделать метод загрузки точек?*