
namespace FileCreaterConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Task 1
            var TestDir1 = FileUsing.DirCreation(@"c:\Otus\TestDir1");
            if (TestDir1 is null) return;
            var TestDir2 = FileUsing.DirCreation(@"c:\Otus\TestDir2");
            if (TestDir2 is null) return;

            //Task 2
            FileInfo[] filesDir1 = new FileInfo[10];
            FileInfo[] filesDir2 = new FileInfo[10];
            for (int i = 0; i < 10; i++)
            {
                filesDir1[i] = FileUsing.FileCreation(Path.Combine(TestDir1.FullName, "File" + (i + 1).ToString()));
                if (filesDir1[i] is null) return;
                filesDir2[i] = FileUsing.FileCreation(Path.Combine(TestDir2.FullName, "File" + (i + 1).ToString()));
                if (filesDir2[i] is null) return;
            }

            //Task3
            foreach (FileInfo file in filesDir1)
            {
                bool complite = await FileUsing.AppendWriteAsync(file, file.Name + '\n');
                if (complite == false)
                {
                    return;
                }
            }
            foreach (FileInfo file in filesDir2)
            {
                bool complite = await FileUsing.AppendWriteAsync(file, file.Name + '\n');
                if (complite == false)
                {
                    return;
                }
            }

            //Task 4
            foreach (FileInfo file in filesDir1)
            {
                bool complite = await FileUsing.AppendWriteAsync(file, DateTime.Now.ToString() + '\n');
                if (complite == false)
                {
                    return;
                }
            }
            foreach (FileInfo file in filesDir2)
            {
                bool complite = await FileUsing.AppendWriteAsync(file, DateTime.Now.ToString() + '\n');
                if (complite == false)
                {
                    return;
                }
            }

            //Task 5
            foreach (FileInfo file in filesDir1)
            {
                bool complite = await FileUsing.ReadAllFile(file);
                if (complite == false)
                {
                    return;
                }
            }
            foreach (FileInfo file in filesDir2)
            {
                bool complite = await FileUsing.ReadAllFile(file);
                if (complite == false)
                {
                    return;
                }
            }

            Console.WriteLine("Program complite success.");
        }
    }
}
