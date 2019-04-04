using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    
    public abstract class Storage
    {
        public string NameOfDevice { get; set; }
        public string ModelOfDevice { get; set; }
        public double FreeSpace { get; set; }
        public abstract double GetMemory();
        public abstract string Copying(File[] files);
        public abstract double GetFreeMemory();
        public abstract string GetAllInfo();
    }
    
}
