// 1. По двум введённым числам проверять является ли первое квадратом второго

Console.WriteLine("Введите 1-e число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-e число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number % number2 ==0)
{
    System.Console.WriteLine("1-e число является квадратом 2-го");
}
else
{
    System.Console.WriteLine("1-e число НЕявляется квадратом 2-го");
}