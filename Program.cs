using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    class Program
    {
        static void Main(string[] args)
        {
            File[] files = new File[5];
            files[0] = new File("file1", 253);
            files[1] = new File("file2", 456);
            files[2] = new File("file3", 785);
            files[3] = new File("file4", 156);
            files[4] = new File("file5", 322);

            Storage disk = new DVD { NameOfDevice = "DVD", ModelOfDevice = "v.1", ReadingSpeed = 4, type = Type.unilateral };
            Storage flash = new Flash { NameOfDevice = "Transcend", ModelOfDevice = "v.2", MemorySize = 6, USB30 = 480 };
            Storage hdd = new HDD { NameOfDevice = "HDD", ModelOfDevice = "v.3", AmountOfSections = 3, MemoryOfSections = 9, USB20 = 900 };

            Console.WriteLine(disk.GetAllInfo()); 
            Console.WriteLine("Время записи файлов: " + disk.Copying(files));
            Console.WriteLine('\n');
            Console.WriteLine(flash.GetAllInfo()); 
            Console.WriteLine("Время записи файлов: " + flash.Copying(files));
            Console.WriteLine('\n');
            Console.WriteLine(hdd.GetAllInfo()); 
            Console.WriteLine("Время записи файлов: " + hdd.Copying(files));
            Console.WriteLine('\n');

            Console.ReadKey();
        }
    }
}
