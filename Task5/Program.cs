int www(ref int a,ref int b)
{
     return a = b;
}
int wow(ref int a,ref int b)
{
    return b = a;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(www(ref a ,ref b)); 
Console.WriteLine(wow(ref a ,ref b)); 
