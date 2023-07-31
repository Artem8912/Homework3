Console.WriteLine("Введите натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}
Console.WriteLine("Введите натуральную степень числа");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}
double Degree(int num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}

double degree = Degree(number1, number2);
Console.WriteLine($"{number1} в степени {number2} равно {degree}");
