// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


System.Console.WriteLine("Введите двухзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void FindMax(int test_number)
{
    if (test_number <= 10 || test_number >= 99)
    {
        System.Console.WriteLine("Число введено не верно");
    }
    else
    {
        int a = test_number % 10;
        int b = test_number / 10;
        if (a < b) System.Console.WriteLine("Большее число: " + b);
        else System.Console.WriteLine("Большее число: " + a);
    }
}

FindMax(number);