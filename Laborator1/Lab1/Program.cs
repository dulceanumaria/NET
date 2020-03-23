using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class PrimeNumberExample
{
    public static int isPrim(int n)
    {
        int m, i, flag = 0;
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                flag = 1;
                break;
            }
        }
        return flag;
    }
    public int metoda1(int n)
    {
        int m = 0, i;
        for (i = 2; i < n; i++)
        {
            if (isPrim(i) == 0)
            {
                m = i;
            }
        }
        return m;
    }
    public int metoda2(int n)
    {
        int i;
        for (i = n - 1; i >= 2; i--)
        {
            if (isPrim(i) == 0)
            {
                return i;
            }
        }
        return 2;
    }
}
class Program
{
    static ConcurrentQueue<String> log = new ConcurrentQueue<String>();
    public static void Metoda1(object x)
    {
        String Timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("Start fir1: " + Timestamp + "; Numar natural dat = " + x.ToString());
        PrimeNumberExample P = new PrimeNumberExample();
        int Nr = P.metoda1((int)x);
        Timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("End fir1: " + Timestamp + "; Numar prim =  " + Nr.ToString());

    }
    public static void Metoda2(object y)
    {
        String Timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("Start fir2: " + Timestamp + "; Numar natural dat = " + y.ToString());
        PrimeNumberExample P = new PrimeNumberExample();
        int Nr = P.metoda2((int)y);
        Timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("End fir2: " + Timestamp + "; Numar prim =  " + Nr.ToString());
    }
    public static void Main(string[] args)
    {
        int x = 5441;
        Thread t1 = new Thread(Metoda1);
        Thread t2 = new Thread(Metoda2);
        t1.Start(x);
        t2.Start(x);
        t1.Join();
        t2.Join();
        List<string> log_l = log.ToArray().ToList();
        foreach (string s in log_l)
        {
            Console.WriteLine(s);
        }
    }
}
