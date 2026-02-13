using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asztali_projekt_ikea
{
    internal class FileManager
    {
        public static List<Ikea> Readfile(string fileName)
        {
            List<Ikea> sorok = new List<Ikea>();
            try
            {
                foreach (string sor in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = sor.Split(";");

                    sorok.Add(new Ikea(temp));

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return  sorok;
        }
    }
}
