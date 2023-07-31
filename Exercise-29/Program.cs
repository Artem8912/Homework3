int[] array = new int[8];

Console.WriteLine("Введите левый предел диапазона случайных чисел");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правый предел диапазона случайных чисел");
int number2 = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

FillMassive( number1, number2,array);
PrintMassive( number1, number2,array);
void FillMassive(int num1,int num2, int[] arr)
    {
        for (int i = 0; i<arr.Length;i++)
            {
                arr[i] = rnd.Next (num1,num2+1);
            }
    }
    void PrintMassive(int num1,int num2, int[] arr)
    {
        for (int i = 0; i<arr.Length;i++)
            {
                Console.Write($"{arr[i],4}," );
            }
    }