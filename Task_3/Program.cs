int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

Console.Write("Введите первое число> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число> ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана: {Ack(m,n)}");