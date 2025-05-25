using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreaterConsole
{
    internal class FileUsing
    {
        public static DirectoryInfo CreationDir(string dirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (!dir.Exists)
            {
                try
                {
                    dir.Create();
                    Console.WriteLine($"Directory {dirPath} created");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return dir;
        }
    }
}
