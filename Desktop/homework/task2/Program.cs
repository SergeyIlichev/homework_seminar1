/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int firstnumber = int.Parse(number1);
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int secondnumber = int.Parse(number2);
Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine();
int thirdnumber = int.Parse(number3);

if(firstnumber>secondnumber && firstnumber>thirdnumber)
{
    Console.WriteLine($"Число {firstnumber} является наибольшим из введеных чисел");
}
else if(firstnumber<secondnumber && secondnumber>thirdnumber)
{
    Console.WriteLine($"Число {secondnumber} является наибольшим из введеных чисел");
}
else if(firstnumber<thirdnumber && secondnumber<thirdnumber)
{
    Console.WriteLine($"Число {thirdnumber} является наибольшим из введеных чисел");
}
else if(firstnumber==thirdnumber && secondnumber==thirdnumber)
{
    Console.WriteLine($"Все введенные числа равны");
}