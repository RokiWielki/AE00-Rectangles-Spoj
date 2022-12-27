using System;

namespace Rectangles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n, cnt = 0;
            n= int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <=n; j++)
                {
                    if (i*j<=n)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
