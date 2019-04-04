using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    public class HDD : Storage
    {
        public int USB20 { get; set; }
        public int AmountOfSections { get; set; }
        public int MemoryOfSections { get; set; }

        public override string Copying(File[] files)
        {
            File file = new File();
            int fullSize = file.GetFullSize(files);
            if (MemoryOfSections * 1024 <= fullSize)
            {
                return "Память заполнена";
            }
            else
            {
                FreeSpace = MemoryOfSections * 1024 - fullSize;
                int sizeInKiloBytes = fullSize * 1024;
                double USBSpeedInKiloBits = USB20 * 1024;
                double loadingTime = sizeInKiloBytes / USBSpeedInKiloBits;
                string result = Convert.ToString(loadingTime);
                return $"{result} сек";
            }
        }
        public override string GetAllInfo()
        {
            return $"Название:{NameOfDevice},\nМодель:{ModelOfDevice},\nПамять:{MemoryOfSections}GB,\nСкорость USB2.0:{USB20}Mbyte/s";
        }
        public override double GetFreeMemory()
        {
            return FreeSpace;
        }
        public override double GetMemory()
        {
            return MemoryOfSections;
        }
    }
}
