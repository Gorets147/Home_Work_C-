// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

System.Console.WriteLine("Введите делимое: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите делитель: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Del(int a, int b)
{
    if (a % b == 0)
    {
        System.Console.WriteLine($"Число {a}, кратно числу {b} и равно {a / b}");
    }
    else
    {
        System.Console.WriteLine($"Число {a}, НЕкратно числу {b} остаток: {a % b}");
    }
}

Del(num1, num2);