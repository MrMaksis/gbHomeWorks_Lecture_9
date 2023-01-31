void NaturalNumSumm(int m, int n, int sum)
{
    if(m > n) { Console.WriteLine($"Сумма натуральных элементов: {sum}"); return; }
    sum = sum + (m++);
    NaturalNumSumm(m,n,sum);
}

Console.Write("Input num M> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num N> ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumSumm(m,n,0);