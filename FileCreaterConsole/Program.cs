namespace FileCreaterConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            var TestDir1 = FileUsing.DirCreation(@"c:\Otus\TestDir1");
            Console.WriteLine(TestDir1.FullName);
            if (TestDir1 is null) return;
            var TestDir2 = FileUsing.DirCreation(@"c:\Otus\TestDir2");
            Console.WriteLine(TestDir2.FullName);
            if (TestDir2 is null) return;

            //Task 2
            FileInfo[] fileDir1 = new FileInfo[10]; 
            FileInfo[] fileDir2 = new FileInfo[10];
            for (int i = 0; i < 10; i++)
            {
                fileDir1[i] = FileUsing.FileCreation(Path.Combine(TestDir1.FullName, "File", i.ToString()));
                if (fileDir1[i] is null) return;
                fileDir2[i] = FileUsing.FileCreation(Path.Combine(TestDir2.FullName, "File", i.ToString()));
                if (fileDir2[i] is null) return;
            }

            //Task3



            Console.WriteLine("Hello, World!");
        }
    }
}
