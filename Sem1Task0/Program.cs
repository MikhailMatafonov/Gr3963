//Напишите программу, которая на вход принимает число и
//выдает его квадрат
// inputNum - название переменной, которую будем вводить
// string? - тип переменной, вопрос - мы пока не проверяем нашу переменную 
//на значение Null (отсутствует значение переменной)
//crossplatform
Console.WriteLine("Введите число, для возведения его в квадрат");
string? inputNum = Console.ReadLine();

//Проверяем данные не были пустые
if (inputNum != null)
{
    //Преобразуем строку в цифры
    int numberA = int.Parse(inputNum);
    //находим квадрат числа
    //int outNum = numberA*numberA;
    int outNum = (int)Math.Pow(numberA,2);
    //выводим данные в консоль
    Console.WriteLine("Квадрат числа:"+outNum);
}
