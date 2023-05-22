Console.Clear();

int num = Convert.ToInt32(Console.ReadLine());
int mag = 0;
int num1 = num;
if (num/100>0)
{
     while(num>0)
    {
        mag=mag+1;
        num= num/10;
    }
    
    
    
    int i = 0;
    //int j =0;
    if(num1>=1000)
    {
        while (i+1 < mag-1)
        {
            i++;
            mag--;
            num1/=10;
        
        }
        System.Console.WriteLine($"третье число: {num1%10}");
    }
    else
    {
        num1%=10;
        System.Console.WriteLine($"третье число: {num1}");
    }
    
}

else
{
    System.Console.WriteLine("третьей цифры нет");
}





