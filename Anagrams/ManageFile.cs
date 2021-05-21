using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class ManageFile
    {
        public int CountFile { get; set; }
        public void GetPath(string[] args)
        {
            if (args[0] == null)
            {
                throw new ArgumentNullException(null, "Debe especificar alguna direccion de archivo de texto");
            }

            if (args.Length == 1 && File.Exists(args[0]))
            {
                string path = args[0];
                StreamReader sr = new StreamReader(path);
                ManageAnagrams manageAnagrams = new ManageAnagrams();

                while (!sr.EndOfStream)
                {
                    string word = sr.ReadLine();
                    CountFile++;
                    manageAnagrams.AnagramsDic(word);
                }
                sr.Close();
                manageAnagrams.PrintDic();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Cantidad de palabras: {CountFile}");
                Console.WriteLine($"Cantidad de sets: {manageAnagrams.CountSets}");
            }
            else
                throw new FileNotFoundException("No se encontro el archivo de texto");

        }
    }
}
