using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleApplication1.FileSaver;
using ConsoleApplication1.Filter;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



            String line = "";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("d:/dirtyfile_2.csv"))
                {

                    line = sr.ReadToEnd();     // Reads the entire stream of text all at once & saves in "line" object
                    
                    using (StreamWriter writer = new StreamWriter(@"d:\text.csv",false,Encoding.)) // UTF-8 encoding is used
                    {
                        writer.WriteLine(line);
                    
                    }
                    
                    Console.WriteLine(line);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }








           

            using (StreamReader sr2 = new StreamReader("d:/dirtyfile_2.csv"))
            {


                while (sr2.Peek() >= 0)
                {

                    string singleline = sr2.ReadLine();  // Reads the entire stream of text line by line

                    string specialcharacterpattern = "[?!a-zA-Z0-9, ._]"; // for special characters

                    Regex reg = new Regex(specialcharacterpattern);
                    string replacementstring = "";
                    string result = reg.Replace(singleline, replacementstring);
                    if (result.Length > 0)
                    {
                        string dirtychars = result;
                        string specialline = singleline;
                        Filterline.Savedirtyrow(specialline);                             // FOR SAVING DIRTY ROWS IN A TXT FILE

                        //dirtyrowfilter.filterdirtyrow(specialline, dirtychars);       
                    }
                    else {
                        string cleanrow = singleline;
                        Filterline.Savecleanrow(cleanrow);                                // FOR SAVING CLEAN ROWS IN A  TXT FILE
                    }
                }

            }










                string pattern = "[^a-zA-Z0-9, ._]";
                string dirtypattern = "[?!a-zA-Z0-9, ._]";
                Regex regex = new Regex(pattern);
                Regex regex2 = new Regex(dirtypattern);
                string replacement = "";
                string replacement2 = "";
                string cleantextdata = regex.Replace(line, replacement);
                string dirtytext = regex2.Replace(line, replacement2);
                Console.WriteLine(cleantextdata);
                Console.WriteLine(dirtytext);
                Console.WriteLine("CODE HIT");
                Filesaver.save(cleantextdata);                       // SAVES all data removing special characters
                Filesaver.saveDirty(dirtytext);                      // SAVES only special chracters symbols 
                Console.ReadLine();
            }
        }
    }

