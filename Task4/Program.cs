// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Input numbers");
int numbers = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if (numbers > 1)
{
    while(evenNumber <= numbers)
    {
        Console.WriteLine(evenNumber + "   ");
        evenNumber = evenNumber + 2;
    }
}