// Напишите программу, которая выводит третью цифру 
//заданного числа, или сообщает что третьей цифры нет.
Console.WriteLine("Введите число");

string? num = Console.ReadLine()??"0";
char[] Arr = num.ToCharArray();
Console.WriteLine(int.Parse((Arr[2]).ToString()));
//
//НЕ решил следующее:
// Console.WriteLine("Введите число");
// int NumberOne = Convert.ToInt32(Console.ReadLine()??"0");
// if(NumberOne > 100)
// {
//     if(NumberOne<1000)
//     {
//         Console.WriteLine("Число " + NumberOne);
//         NumberOne/=10; //Определяем цифру
//         int Lastnum = NumberOne%10;
//         Console.WriteLine("Третья цифра числа " + Lastnum); //выводим результат
//     }
// }
// else
// {
//     Console.WriteLine("У данного числа нет третьей цифры " + NumberOne);
// }



