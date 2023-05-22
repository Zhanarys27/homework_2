Console.Clear();
int num = Convert.ToInt32(Console.ReadLine());
if(num==6 || num == 7)
{
    System.Console.WriteLine("yeap, it's a weekend!");
}
else if (num <= 0 || num >= 7)
{
    System.Console.WriteLine("error");    
}
else
{
    System.Console.WriteLine("no");
}
