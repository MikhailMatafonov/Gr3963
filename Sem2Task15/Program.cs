//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.  

Console.WriteLine("Введите число");
int NumberOne = int.Parse(Console.ReadLine()??"0");

if(NumberOne>0 && NumberOne<8)
{
    string[] DayWeek = {"понедельник - рабочий день", "вторник - рабочий день", "среда - рабочий день", "четверг - рабочий день", "пятница - рабочий день", "суббота - выходной", "воскресенье - выходной"};
    Console.WriteLine(DayWeek[NumberOne-1]);
}
else
{
    Console.WriteLine("Это не день недели");
}

// Dictionary<int, string> people = new Dictionary<int, string>();
// {
//     [5] = "Tom",
//     [6] = "Sam",
//     [7] = "Bob"
// };

