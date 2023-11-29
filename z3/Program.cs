// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M -> ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N -> ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана от чисел {M} и {N} = {Ack(M, N)}");

int Ack(int numberOne, int numberTwo)
{
    if (numberOne == 0) return numberTwo + 1;
    else if (numberTwo == 0) return Ack(numberOne - 1, 1);
    else return Ack(numberOne - 1, Ack(numberOne, numberTwo - 1));
}