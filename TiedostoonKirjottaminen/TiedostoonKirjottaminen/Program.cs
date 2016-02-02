using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TiedostoonKirjottaminen
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimet;
            StreamWriter sw;
            

            sw = new StreamWriter(@"d:\T1lines.txt");
           
            

            do
            {
                Console.Write("Give a text line (enter ends) : ");
                nimet = Console.ReadLine();
                sw.WriteLine(nimet);
              
            } while (nimet.Length != 0);

            
            sw.Close();

            try
            {
                //vaihda @"d:\T1line.txt" kohtaan loppuun s-kirjain nii toimii
                string text = System.IO.File.ReadAllText(@"d:\T1line.txt");
                System.Console.WriteLine("\nTiedoston sisältö\n" + text);

            }catch (FileNotFoundException)
            {
                Console.WriteLine("\nFile not found");
            }

            
        }
    }
}
