/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int number1 = int.Parse(number);
int number2 = 1;

for (int i=number2;i<=number1;i++)
{
if(i%2==0)
{
    Console.WriteLine(i);
}
}
