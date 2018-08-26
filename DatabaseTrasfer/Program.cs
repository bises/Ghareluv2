using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace DatabaseTrasfer
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Match match;
            string pattern = @"(.+?)=(.*)";
            bool readBegin = false;
            IDictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                using (StreamReader fs = new StreamReader(@"C:\Users\achar\Desktop\Database.ini"))
                {
                    while ((line = fs.ReadLine()) != null)
                    {
                        if (line.Contains("[section"))
                        {
                            readBegin = true;
                            continue;
                        }
                        if (readBegin)
                        {
                            match = Regex.Match(line, pattern);
                            dictionary.Add(match.Groups[1].Value, match.Groups[2].Value);
                        }
                        if (line.Contains("pan_no="))
                        {
                            Console.WriteLine(dictionary["reg_num"]);
                            readBegin = false;
                            dictionary.Clear();
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
