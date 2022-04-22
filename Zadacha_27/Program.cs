//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//вариант 1

/*

Console.WriteLine("Введите число: ");                   
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;

while (number != 0)
{
    number = number / 10;
    result = result + number % 10;
}
Console.WriteLine(result);

*/

//вариант 2

Console.Write("Введите число: ");
string number = Console.ReadLine();

int sum = 0;
for(int i = 0; i < number.Length; i++)
{
    sum += Convert.ToInt32(number[i].ToString());
}

Console.WriteLine("Сумма цифр: " + sum);