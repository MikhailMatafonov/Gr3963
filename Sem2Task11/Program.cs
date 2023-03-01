//Напишите программу, которая выводит случайно 3-х
//значное число и удаляет вторую цифру данного числа.
System.Random  Number = new System.Random();

int NumberOne = Number.Next(100,1000);
Console.WriteLine("Сгенерированнное первое число " + NumberOne);
int Lastnum = NumberOne % 10;
Console.WriteLine("Последнее число " + Lastnum);
int Tonum = NumberOne / 100;
Console.WriteLine("Первое число " + Tonum);

int Number2 = Tonum * 10 + Lastnum;
Console.WriteLine(Number2);

//"Схлопнули запись + задали ещё одно число"
NumberOne = Number.Next(100,1000);
Console.WriteLine("Сгенерированнное второе число " + NumberOne);
Console.WriteLine((NumberOne / 100)*10 +(NumberOne % 10)); 


// "Ещё одно интересное решение"
NumberOne = Number.Next(100,1000);
Console.WriteLine("Сгенерированнное третье число " + NumberOne);

char[] digits1 = NumberOne.ToString().ToCharArray();
Console.WriteLine(int.Parse((digits1[0]).ToString())*10+int.Parse((digits1[2]).ToString()));