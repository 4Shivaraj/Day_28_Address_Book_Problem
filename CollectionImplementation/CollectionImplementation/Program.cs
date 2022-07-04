// See https://aka.ms/new-console-template for more information

namespace Collection
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Collection Learning Problem");
            Collection collection = new Collection();
            collection.AddDictionary();
            collection.AddStack();
            collection.AddLinkList();
            collection.AddingList();
            collection.AddQueue();

        }
    }
}
