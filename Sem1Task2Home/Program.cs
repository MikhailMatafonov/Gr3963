//Напишите программу, которая на входе принимает 2 числа 
//и выдаёт какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
if(A > B)
    {
    Console.WriteLine($"Число {A} больше числа {B}");
    }
if(A < B)
    {
    Console.WriteLine($"Число {B} больше числа {A}");
    }
if(A == B)
    {
    Console.WriteLine($"Число {A} равно числу {B}");
    }
