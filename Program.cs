using System;

namespace 輾轉相除法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] intput;
            while ((intput = Console.ReadLine().Split()) != null)
            {

                int a = int.Parse(intput[0]);
                int b = int.Parse(intput[1]);
                int ans = 0;

                for (int i = 0; i < a + b; i++)
                {
                    if (a > b)
                    {
                        a = a % b;
                        if (a == 0)
                        {
                            ans = b;
                            break;
                        }
                    }
                    else
                    {
                        b = b % a;
                        if (b == 0)
                        {
                            ans = a;
                            break;
                        }
                    }
                }
                Console.WriteLine(ans);
            }
           
        }
    }
}
