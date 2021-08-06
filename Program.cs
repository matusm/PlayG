using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayG
{
    class Program
    {
        static void Main(string[] args)
        {
            //double sm = 1.2217;
            //double sm = 5.4911;
            double sm = 1.00001;


            double x1 = 65535 / (sm * 0.999985);
            int x1i = (int)Math.Round(x1);

            byte[] bytes = BitConverter.GetBytes(x1i);
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            Console.WriteLine(sm);
            Console.WriteLine(x1);
            Console.WriteLine(x1i);
            Console.WriteLine();

            foreach (var b in bytes)
            {
                Console.WriteLine($"{b:X2}");
            }

            Console.WriteLine();

            int serialNumber = 52365;
            byte[] bytes1 = BitConverter.GetBytes(serialNumber);
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            Console.WriteLine($"{bytes1[0]:X2}");
            Console.WriteLine($"{bytes1[1]:X2}");

        }
    }
}
