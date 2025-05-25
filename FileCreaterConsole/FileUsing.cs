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
                    ErrorMessage(e.Message);
                    return null;
                }
            }

            return dir;
        }
        public static FileInfo FileCreation(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            if (!file.Exists)
            {
                try
                {
                    using (file.Create()) { }//Чтобы вернуть доступ к файлу
                    Console.WriteLine($"File {filePath} created.");
                }
                catch (Exception e)
                {
                    ErrorMessage(e.Message);
                    return null;
                }
            }

            return file;
        }
        public static async Task<bool> AppendWriteAsync(FileInfo file, string text)
        {
            if (!file.Exists)
            {
                ErrorMessage($"File: {file.FullName} doesn't exits.");
                return false;
            }

            try
            {
                await File.AppendAllTextAsync(file.FullName, text, Encoding.UTF8);
                Console.WriteLine($"Text {text} added to {file.FullName}");
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                return false;
            }

            return true;
        }
        public static async Task<bool> ReadAllFile(FileInfo file)
        {
            if (!file.Exists)
            {
                ErrorMessage($"File: {file.FullName} doesn't exits.");
                return false;
            }

            try
            {
                string text = await File.ReadAllTextAsync(file.FullName);
                Console.WriteLine($"{file.Name}: " + text);
            }
            catch (Exception e)
            {
                ErrorMessage(e.Message);
                return false;
            }

            return true;
        }
        private static void ErrorMessage(string message)
        {
            var tempConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = tempConsoleColor;
        }
    }
}
