using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    public enum Type
    {
        unilateral,
        bilateral
    }
    public class DVD : Storage
    {
        public double ReadingSpeed { get; set; }
        public Type type { get; set; }

        public override string Copying(File[] files)
        {
            File file = new File();
            int fullSize = file.GetFullSize(files);
            double whatType = 0;
            if (type == Type.unilateral)
            {
                whatType = 4.7 * 1024;
            }
            else
            {
                whatType = 9 * 1024;
            }
            if (whatType <= fullSize)
            {
                return "Память заполнена";
            }
            else
            {
                FreeSpace = whatType - fullSize;
                int sizeInKiloBytes = fullSize * 1024;
                double ReadingSpeedInKiloBits = ReadingSpeed * 1024;
                double loadingTime = sizeInKiloBytes / ReadingSpeedInKiloBits;
                string result = Convert.ToString(loadingTime);
                return $"{result} сек";
            }
        }

        public override double GetFreeMemory()
        {
            return FreeSpace;
        }
        public override string GetAllInfo()
        {
            return $"Имя:{NameOfDevice},\nМодель:{ModelOfDevice},\nТип:{type},\nСкорость чтения:{ReadingSpeed}Mb/s";
        }


        public override double GetMemory()
        {
            if (type == Type.unilateral)
            {
                return 4.7;
            }
            else
            {
                return 9;
            }
        }
    }
}
