// Программа, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
void Palindrome(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine($"{number}, + , Число является палиндромом");
    else
        Console.WriteLine($"{number}, - , Число не является палиндромом");
}
if (number.Length == 5)
{
    Palindrome(number);
}
else
    Console.WriteLine("Число не пятизначное, попробуйте еще раз");