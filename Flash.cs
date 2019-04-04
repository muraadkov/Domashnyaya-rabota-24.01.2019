using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    public class Flash : Storage
    {
        public double USB30 { get; set; }
        public double MemorySize { get; set; }

        public override string Copying(File[] files)
        {
            File file = new File();
            int fullSize = file.GetFullSize(files);
            if (MemorySize * 1024 <= fullSize)
            {
                return "Память заполнена";
            }
            else
            {
                FreeSpace = MemorySize * 1024 - fullSize;
                int sizeInKiloBytes = fullSize * 1024;
                double USBSpeedInKiloBits = USB30 * 1024;
                double loadingTime = sizeInKiloBytes / USBSpeedInKiloBits;
                string result = Convert.ToString(loadingTime);
                return $"{result} сек";
            }
        }

        public override string GetAllInfo()
        {
            return $"Название:{NameOfDevice},\nМодель:{ModelOfDevice},\nПамять:{MemorySize}GB,\nСкорость USB3.0:{USB30}Mb/s";
        }
        public override double GetFreeMemory()
        {
            return FreeSpace;
        }
        public override double GetMemory()
        {
            return MemorySize;
        }
    }
}
