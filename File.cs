using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    public class File
    {
        public string NameOfFile { get; set; }
        public int SizeOfFile { get; set; }
        public File()
        {

        }
        public File(string name, int size)
        {
            NameOfFile = name;
            SizeOfFile = size;
        }
        public int GetFullSize(File[] files)
        {
            int result = 0;
            for (int i = 0; i < files.Length; i++)
            {
                result += files[i].SizeOfFile;
            }
            return result;
        }
    }
}
