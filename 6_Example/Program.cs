//  5. Написать программу вычисления значения функции y=2x-1

Console.WriteLine("Введите значение x");

int x = Convert.ToInt32(Console.ReadLine());

if (x > 0)
{
    int y = 2 * x - 1;
    System.Console.WriteLine("Значение y = " + y);
}
