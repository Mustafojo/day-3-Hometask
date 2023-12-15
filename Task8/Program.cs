void www(ref int a,ref int b,ref int c,ref int d)
{
if(a<=b  && a<=c  && a<=d)
    {
       Console.WriteLine(a);
    }
else if(b<=a  && b<=c  && b<=d)
    {
       Console.WriteLine(b);
    }
else if(c<=a  && c<=b  && c<=d)
    {
        Console.WriteLine(c);
    }
else if(d<=a && d<=b && d<=c)
    {
        Console.WriteLine(d);
    }
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

www(ref a,ref b,ref c,ref d);

