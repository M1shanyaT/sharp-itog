// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M -> ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N -> ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numberOne, int numberTwo)
{
if (numberOne == numberTwo) return numberTwo;
return numberOne + SumNumbers(numberOne + 1, numberTwo);
}

Console.WriteLine($"Сумма чисел от {M} до {N} = {SumNumbers(M , N)}");