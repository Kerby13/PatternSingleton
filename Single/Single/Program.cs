using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletop singl = new Singletop();
            singl.Launch("Windows 10");
            Console.WriteLine(singl.OS.Name);

            singl.Launch(Console.ReadLine());
            Console.WriteLine(singl.OS.Name);
            Console.ReadLine();
        }
    }
}
