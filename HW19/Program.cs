/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите пятизначное число");
int reverse = 0;
int num = number;
while (num != 0)
{
    reverse = reverse * 10 + num % 10;
    num = num / 10;
}
if (reverse == number)
{
    System.Console.WriteLine($"Число является полиндромом");
}
else System.Console.WriteLine($"Число не является полиндромом");
