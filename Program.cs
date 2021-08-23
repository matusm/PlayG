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
            // convert double to mantissa and exponent
            double s = 05.4911E-10;
            //double s = 1.00001E-10;

            double exp = Math.Floor(Math.Log10(Math.Abs(s)));
            double sm = s / Math.Pow(10, exp);
            int sExp = (int)exp;

            Console.WriteLine($"{s}  ->  mantissa: {sm}  exponent: {sExp}");
            Console.WriteLine();


            // convert the mantissa of a calibration factor
            double normalizedSm = 65535 / (sm * 0.999985);
            int integerNormalizedSm = (int)Math.Round(normalizedSm);

            byte[] bytesSm = BitConverter.GetBytes(integerNormalizedSm);
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytesSm);

            Console.WriteLine(sm);
            Console.WriteLine(normalizedSm);
            Console.WriteLine(integerNormalizedSm);
            Console.WriteLine();

            foreach (var b in bytesSm)
            {
                Console.WriteLine($"{b:X2}");
            }
            Console.WriteLine();


            // convert a serial number
            int serialNumber = 52365;
            byte[] bytesSN = BitConverter.GetBytes(serialNumber);
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytesSN);
            Console.WriteLine($"{serialNumber}");
            foreach (var b in bytesSN)
            {
                Console.WriteLine($"{b:X2}");
            }
            Console.WriteLine();

        }
    }
}
