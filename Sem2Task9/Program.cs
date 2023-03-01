// Напишите программу, которая выводит  случайное число из 
//отрезка [10,99] и показывает наибольшую цифру числа.
Console.WriteLine("Случайное число");
System.Random numSintezator = new System.Random();
//Вариант 1

int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

if(firstNum>secondNum)
{
    Console.WriteLine("Первое число " + firstNum + " больше второго " + secondNum);
}
else
{
    Console.WriteLine("Второе число = " + secondNum + " больше первого "+ firstNum);
}

//Вариант 2

char[] digits  = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits); //Выводим сгенерированное число
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;
//Тернарный оператор:
int resultNumber = firstNumber>secondNumber?resultNumber = firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);

//Вариант 3

//Задача с заданным массивом(смотреть видео!)