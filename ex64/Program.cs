// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int M = 1; 

void EvenNumbersfromMtoN (int m, int n)
{
    if (n == m)
    {
        //Console.Write("{0, 4}", n);
        return;
    } 
    if (n % 2 == 0)
    {
        Console.Write("{0, 4}", n);
    }
EvenNumbersfromMtoN(m, n - 1);
}

EvenNumbersfromMtoN(M, N);
Console.WriteLine();




