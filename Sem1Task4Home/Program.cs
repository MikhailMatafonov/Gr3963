//Напишите программу , которая принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine());
if(A > B)
{
    if(A > C)
    {
        Console.WriteLine($"Число {A} является максимальным");
    }
    else
    {
        Console.WriteLine($"Число {C} является максимальным");
    }
}    
else
{
if(B > C)
    Console.WriteLine($"Число {B} является максимальным");
    else
    {
    Console.WriteLine($"Число {C} является максимальным");
    }
}


        
    
    
