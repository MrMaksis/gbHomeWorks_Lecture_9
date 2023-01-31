void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

Console.Write("Please input num> ");
ShowNums(Convert.ToInt32(Console.ReadLine()));