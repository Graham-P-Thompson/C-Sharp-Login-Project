// Graham Thompson 28/02/23 Login Project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LoginProject
{
    internal class FileAccess
    {
        public static string[] GetFileContent()
        {
            // Get content from a file and return each line as an element in an array.
            string path = GetPathToAccounts();

            try
            {
                using (FileStream fr = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fr))
                    {
                        string[] lines = new string[50];
                        for (int i = 0; i < lines.Length; i++)
                        {
                            lines[i] = sr.ReadLine();
                        }
                        return lines;
                    }
                }
            }
            catch (FileNotFoundException ex)
            { 
                return new string[1] {ex.Message};
            }
        }

        public static void AppendToFile(string content)
        {
            // Appends content to end of txt file.
            // NOTE: txt file has to be saved with curser directly after last character.
            string path = GetPathToAccounts();
            try
            {
                using (FileStream fa = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fa))
                    {
                        sw.WriteLine(content);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string GetPathToAccounts()
        {
            // Generates file path to accounts.txt
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // Current directory C# is looking at.
            
            string loginProjectFolder = Path.Combine(baseDir, "..", "..", "..", "accounts.txt");
            // file accounts.txt is stored 3 files up in directory tree.
            
            string completePath = Path.GetFullPath(loginProjectFolder);

            return completePath;
        }
    }
}