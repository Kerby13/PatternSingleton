using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    class Singletop
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }   
    class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        private static object syncRoot = new Object();

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new OS(name);
                }
            }
            return instance;
        }
    }
}
