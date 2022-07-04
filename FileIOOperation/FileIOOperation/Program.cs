// See https://aka.ms/new-console-template for more information

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            JasonDataOperaton.JsonSerialize();
            JasonDataOperaton.JsonDeserialize();
            Console.ReadLine();
        }
        public static bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                return true;
            }
            else
            {
                Console.WriteLine("File Not Exists");
                return false;
            }
        }
    }
}