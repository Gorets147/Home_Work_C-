//  4. Найти максимальное из трех чисел

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
// int Compare(int number1; int number2; int number3)

int max = 0;
if (number1 < number2)
{
    max = number2;
}
else
{
    max = number1;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine(max);