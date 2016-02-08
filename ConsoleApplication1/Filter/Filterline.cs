using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication1.Filter
{
    class Filterline

    {




        // FOR SAVING DIRTY ROWS
        public static void Savedirtyrow(string dirtyline) 
        {
           using ( StreamWriter writer = new StreamWriter(@"d:\dirtyrows.txt",true))
           {
                                          
            writer.WriteLine(dirtyline);   

            Console.WriteLine(dirtyline);
            Console.WriteLine("dirty line");



           
           }
        }


         // FOR SAVING CLEAN ROWS
           public static void Savecleanrow(string cleanline)
        {
           using ( StreamWriter writer = new StreamWriter(@"d:\cleanrows.txt",true))
           {
            
               writer.WriteLine(cleanline);

               Console.WriteLine(cleanline);
               Console.WriteLine("special line");
        }
          
     }

        
        









    }
    /*class dirtyrowfilter
    {
        // FOR FILTERING DIRTY ROWS ENTRY FROM TABLE USING DICTIONARY & SAVING IT IN A CLEAN FILE
        public static void filterdirtyrow(string dirtyrow, string dirtychars)
        {
            Dictionary<char, char> replacementDictionary = new Dictionary<char, char>();
            
            replacementDictionary.Add('ê', 'e');
            replacementDictionary.Add('è', 'e');
            replacementDictionary.Add('ñ', 'n');



            string cleanstring = "";
            foreach (char dchar in dirtychars)
            {

                cleanstring = dirtyrow.Replace(dchar, replacementDictionary['è']);
                
                   
                
               
                

                using (StreamWriter writer = new StreamWriter(@"d:\cleandictrows.txt", true))
                {
                    writer.WriteLine(cleanstring);
                    Console.WriteLine(cleanstring);

                }

                */

            }

   
