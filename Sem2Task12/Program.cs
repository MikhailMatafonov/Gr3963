// Напишите программу, которая будет принимать на вход 2 числа и выводить , 
//является ли  второе число кратным первому, если второе число не кратно 
//первому, то  программа выводиит остаток от деления

System.Random  Number = new System.Random();
//генерируем двухзначное целое число
int NumberOne = Number.Next(10,100);
Console.WriteLine("Сгенерированнное число = " + NumberOne);
Console.Write("Введите число: ");
int  Num1 = Convert.ToInt32(Console.ReadLine()); //эта функция медленнне, чем через Parse
Console.WriteLine((NumberOne%Num1==0)? "Кратное число " + Num1:"Не кратное, остаток " + NumberOne%Num1);

// Пример с доски

int  fstNum = int.Parse(Console.ReadLine()??"0");
int  scdNum = Convert.ToInt32(Console.ReadLine());
if(fstNum%scdNum==0)
{
    Console.WriteLine("Кратное число " + fstNum);
}
else
{
    Console.WriteLine("Не кратное, остаток " + fstNum%scdNum);
}