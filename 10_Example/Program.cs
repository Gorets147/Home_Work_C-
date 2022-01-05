// 10. Показать вторую цифру трёхзначного числа


System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine((number/10)%10);

