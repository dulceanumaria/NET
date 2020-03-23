using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class PrimeNumberExample
{
    public static int IsPrim(int n)
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
    public int GetMaxPrime1(int n)
    {
        int m = 0, i;
        for (i = 2; i < n; i++)
        {
            if (IsPrim(i) == 0)
            {
                m = i;
            }
        }
        return m;
    }
    public int GetMaxPrime2(int n)
    {
        int i;
        for (i = n - 1; i > 2; i--)
        {
            if (IsPrim(i) == 0)
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
    public static void Thread1(object nr)
    {
        String timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("Start fir1: " + timestamp + "; Numar natural dat = " + nr.ToString());
        PrimeNumberExample P = new PrimeNumberExample();
        int prime = P.GetMaxPrime1((int)nr);
        timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("End fir1: " + timestamp + "; Numar prim =  " + prime.ToString());

    }
    public static void Thread2(object nr)
    {
        String timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("Start fir2: " + timestamp + "; Numar natural dat = " + nr.ToString());
        PrimeNumberExample P = new PrimeNumberExample();
        int prime = P.GetMaxPrime2((int)nr);
        timestamp = DateTime.Now.ToString("HH:mm:ss");
        log.Enqueue("End fir2: " + timestamp + "; Numar prim =  " + prime.ToString());
    }
    public static void Main(string[] args)
    {
        int number = 726;
        Thread thread1 = new Thread(Thread1);
        Thread thread2 = new Thread(Thread2);
        thread1.Start(number);
        thread2.Start(number);
        thread1.Join();
        thread2.Join();
        List<string> log_l = log.ToArray().ToList();
        foreach (string s in log_l)
        {
            Console.WriteLine(s);
        }
    }
}
