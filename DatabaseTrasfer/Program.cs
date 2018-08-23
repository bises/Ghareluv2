using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTrasfer
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                using (StreamReader fs = new StreamReader(@"C:\Users\achar\Desktop\Database.ini"))
                {
                    while ((line = fs.ReadLine()) != null)
                    {
                        if (line.Contains("[section"))
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
