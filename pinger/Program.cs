using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinger
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ipp = new Random();
            string ipAddress;

            for (int i = 0; i < 10;i++ )
            {
            ipAddress = ipp.Next(255) + "." + ipp.Next(255) + "." + ipp.Next(255) + "." + ipp.Next(255);
            Process.Start("ping", ipAddress).WaitForExit();
                }
        }
    }
}
