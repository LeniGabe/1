//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

try
{
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;

while(i <= N)
{
    if(i % 2 == 0)
{
        Console.Write($"{i} ");
        i++;
}
else
{
      i++;
}
}
}
catch
{
    Console.WriteLine("Вы ввели некоректные данные");
}