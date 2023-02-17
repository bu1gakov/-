Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int current = 2;
if(a < 2)
{
    Console.WriteLine($"Чётных чисел от 1 до {a} нет");
}
else 
{
    Console.Write($"Чётные числа от 1 до {a}: ");
    while (current <= a)
    {
        Console.Write($"{current} ");
        current = current +2;
    }
}