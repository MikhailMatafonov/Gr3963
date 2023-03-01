// Напишите програму, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int NumberOne = int.Parse(Console.ReadLine()??"0");
if(NumberOne > 100 && NumberOne < 1000) //проверяем, что число трехзначное
{
    Console.WriteLine("Число трёхзначное " + NumberOne);
    int NumberTwo = (NumberOne/10)%10; //Определяем среднюю цифру
    Console.WriteLine("Вторая цифра числа " + NumberTwo); //выводим результат
}
else
{
    Console.WriteLine("Данное число не является трехзначным " + NumberOne);
}


//

Console.WriteLine("Введите трёхзначное число");
int Number = int.Parse(Console.ReadLine()??"0");
char[] digits1 = Number.ToString().ToCharArray(); // вводим тип char - символы, задаем массив
Console.WriteLine(int.Parse((digits1[1]).ToString())); // выводим вторую цифру из массива символов, индекс 1