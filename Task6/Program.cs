Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());;
int ostatok = a%2;
if (ostatok == 0)
{
    Console.WriteLine($"Число {a} - чётное");
}
else
{
    Console.WriteLine($"Число {a} делится на два с остатоком {ostatok}");
} 