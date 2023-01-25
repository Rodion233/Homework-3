/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Prompt("Введите число N");
int index = 1;
while (index <= x1)
{
    double r = Math.Pow(index, 3);
    System.Console.WriteLine(r);
    index++;
}