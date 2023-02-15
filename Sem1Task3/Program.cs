//Напишите программу , которая будет выдавать название недели по заданному номеру.

Console.WriteLine("Введите число");
var Day = Convert.ToInt32(Console.ReadLine());
if(Day > 0 && Day < 8)
{
    string[] DayWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
    Console.WriteLine(DayWeek[Day-1]);
}
else
{
Console.WriteLine("Вы ввели не день недели");
}

//////

Console.WriteLine("Введите число");
string? DayLine = Console.ReadLine();
if(DayLine != null)
{
 //   int Today = int.Parse(DayLine);
 //   string[] DayToday = new string[7];
 //  DayToday[1] = "понедельник";
 //   DayToday[2] = "вторник";
 //   DayToday[3] = "среда";
 //   DayToday[4] = "четверг";
 //   DayToday[5] = "пятница";
 //   DayToday[6] = "суббота";
 //   DayToday[7] = "воскресенье";
 //   Console.WriteLine(DayToday[Today - 1]);


    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(Day));
    Console.WriteLine(outDayOfWeek);
}