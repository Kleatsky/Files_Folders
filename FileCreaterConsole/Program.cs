namespace FileCreaterConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            var TestDir1 = FileUsing.CreationDir(@"c:\Otus\TestDir1");
            Console.WriteLine(TestDir1.FullName);
            if (TestDir1 is null) return;
            var TestDir2 = FileUsing.CreationDir(@"c:\Otus\TestDir2");
            Console.WriteLine(TestDir2.FullName);
            if (TestDir2 is null) return;

            //Task 2
            Console.WriteLine("Hello, World!");
        }
    }
}
