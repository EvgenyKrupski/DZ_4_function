//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//вариант 1

/*

Console.Write("Введите число A: ");                   
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B, которое больше или равно нулю: ");                   
int B = Convert.ToInt32(Console.ReadLine());

double step =0;

if (B >= 0 )
{
    step = Math.Pow(A, B);
}
else
{
    Console.WriteLine("Введите верное число B"); 
}
Console.WriteLine(step);

*/

//вариант 2

Console.Write("Напишите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Получается " + Step(numberA, numberB));

int Step(int number, int step)
{
    int result = 1;
    for(int i = 0; i < step; i++)
    {
        result *= number;
    }
    return result;
}