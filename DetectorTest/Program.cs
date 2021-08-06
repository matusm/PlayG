using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bev.Instruments.P9710.Detector;

namespace DetectorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new P9710Detector("COM1");

            Console.WriteLine();
            //Console.WriteLine(device.RamToString());
            Console.WriteLine();

            device.WriteCalibrationFactorToRam(5.4911, -10);
            //device.SaveRamToEeprom();

            //Console.WriteLine(device.RamToString());
            Console.WriteLine();
        }
    }
}
