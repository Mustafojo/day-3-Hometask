int a = Convert.ToInt32(Console.ReadLine());
int cnt=0;

for(int i = 1 ; i<=a ; i++ )
{
    if(a%i==0)
    {
        System.Console.Write(i + " ");
        cnt++;
        
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Taksimkunanda = " + cnt);