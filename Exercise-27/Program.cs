Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;

int result = Summ(number);
Console.WriteLine($"Сумма цифр числа равна {result}");

int Summ(int num)
{
    while (num > 0)
    {
        summ += num % 10;
        num = num / 10;
    }
    return summ;
}

