using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreaterConsole
{
    internal class FileUsing
    {
        public static DirectoryInfo DirCreation(string dirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (!dir.Exists)
            {
                try
                {
                    dir.Create();
                    Console.WriteLine($"Directory {dirPath} created.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return dir;
        }
        public static FileInfo FileCreation(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            if(!file.Exists)
            {
                try
                {
                    file.Create();
                    Console.WriteLine($"File {filePath} created.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return file;
        }
    }
}
