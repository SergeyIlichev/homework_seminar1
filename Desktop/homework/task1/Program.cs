/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int firstnumber = int.Parse(number1);
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int secondnumber = int.Parse(number2);
if(firstnumber>secondnumber)
{
    Console.WriteLine($"Число {firstnumber} больше числа {secondnumber}");
}
if(firstnumber<secondnumber)
{
    Console.WriteLine($"Число {firstnumber} меньше числа {secondnumber}");
}
if(firstnumber==secondnumber)
{
   Console.WriteLine($"Числа {firstnumber} и {secondnumber} равны"); 
}