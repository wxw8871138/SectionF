using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionF
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[12];
            for(int i = 0; i < sales.Length; i++)
            {
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < sales.Length-1; i++)
            {
                if (sales[i] < sales[i + 1])
                {
                    max = i + 1;
                }
            }
            Console.WriteLine("max month:{0}", max);
            double sum = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                sum = sum + sales[i];
            }
            Console.WriteLine(sum / 12);
        }
    }
}
