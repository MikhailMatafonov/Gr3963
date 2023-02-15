//Console.WriteLine("Введите значение N");
//string? LineN = Console.ReadLine();
//if(LineN != null)
//{
//    int N = int.Parse(LineN);

//    int negN = N*(-1);
//    string result = string.Empty;
    
//    while (negN<=N);
//   {
//        result = result + negN + ", ";
//        negN++;
//    }    
//     result = result + N;
//    Console.WriteLine(result);
//}

//////////////////////////////////
Console.WriteLine("Введите значение N");
var day = Convert.ToInt32(Console.ReadLine());
var negDay = -day; 
 
for (; negDay <= day; negDay++)
{
    Console.Write(negDay+"\t");
}