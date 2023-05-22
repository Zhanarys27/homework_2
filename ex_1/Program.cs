Console.Clear();

int num = Convert.ToInt32(Console.ReadLine());
if (num/100>0)
{
    if(num/1000>0)
    {
        System.Console.WriteLine("данное число больше 3 значного числа");
    }
    else
    {
        int x1 = num%100;
        int x2 = x1/10;
        System.Console.WriteLine(x2);
    }
}

else
{
    System.Console.WriteLine("данное число меньше трехзначного числа");
}