// 2. Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите 1-e число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-e число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number < number2)
{
    System.Console.WriteLine(number + " Меньшее число");
    System.Console.WriteLine(number2 + " Большее число");
}
else
{
    System.Console.WriteLine(number + " Большее число");
    System.Console.WriteLine(number2 + " Меньшее число");
}