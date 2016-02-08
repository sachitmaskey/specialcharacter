using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1.FileSaver
{
    class Filesaver
    {
        public static void save(string textdata)
        {
            
            File.WriteAllText(@"d:\allcleandata.txt", textdata);            // FOR SAVING (all CLEAN DATA) by removing special characters 
            Console.WriteLine("CLEAN file saved");
        }
        public static void saveDirty(string textdata) {
            File.WriteAllText(@"d:\alldirtydata.txt", textdata);            // FOR SAVING ONLY SPECIAL SYMBOLS
            Console.WriteLine("DIRTY file saved");
        }
    }
}
