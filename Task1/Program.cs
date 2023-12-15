void www( int a)
{
    int cnt = 0;
      for (int i = 0; i < a; i/=10)
    {
        if(i%2==0)
        {
            cnt++;
        }
    }

}

void oww( int a)
{
    int cnn = 0;
      for (int i = 0; i < a; i/=10)
    {
        if(i%2!=0)
        {
            cnn++;
        }
    }

}

void wow( int a)
{
    int ctt = 0;
      for (int i = 0; i < a; i/=10)
    {
        if(i==0)
        {
            ctt++;
        }
    }

}


void wwo( int a)
{
    int cct = 0;
      for (int i = 0; i < a; i/=10)
  
        {
            cct+=i;
        }
  
}
int a = Convert.ToInt32(Console.ReadLine());

www(a);
oww(a);
wow(a);
wwo(a);





  

