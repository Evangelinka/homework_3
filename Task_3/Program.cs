// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubesN(int N)
{
    int i = 1;
    while (i < N)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    Console.Write($"{Math.Pow(i, 3)}. ");
}
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubesN(number);