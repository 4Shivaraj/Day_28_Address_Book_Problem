using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Collection
    {
        public void AddingList()
        {
            List<string> List1 = new List<string>();
            List1.Add("Shivaraj");
            List1.Add("Arun");
            List1.Add("Deepak");
            List1.Contains("Arun");
            List1.Remove("Arun");
            foreach (var elements in List1)
            {
                Console.WriteLine(elements);
            }
        }
        public void AddDictionary()
        {
            Dictionary<int, string> Dictionary1 = new Dictionary<int, string>();
            Dictionary1.Add(1, "Shivaraj");
            Dictionary1.Add(2, "Arun");
            Dictionary1.Add(3, "Deepak");
            Console.WriteLine("Access value using key(key=1):" + Dictionary1);
            Console.WriteLine("\niterating");
            foreach (var elements in Dictionary1)
            {
                Console.WriteLine("key=" + elements.Key + " & Value=" + elements.Value);
            }
        }
        public void AddStack()
        {
            Stack<string> Stack1 = new Stack<string>();
            Stack1.Push("Shivaraj");
            Stack1.Push("Arun");
            Stack1.Push("Deepak");
            Stack1.Push("Cheluvesh");
            string pop = Stack1.Pop();
            foreach (var elements in Stack1)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("poped elements:" + pop);

        }
        public void AddLinkList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Gowri");

        }
        public void AddQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Shivaraj");
            queue.Enqueue("Arun");
            queue.Enqueue("Deepak");
            queue.Enqueue("Ganga");
            queue.Enqueue("Cheluvesh");
            Console.WriteLine("Head:" + queue.Peek());//peek display top elemnts in stack or queue
            Console.WriteLine("\niterating trough the queue");
            foreach (var elements in queue)
            {
                Console.WriteLine(elements);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("\nDequeue elements" + dequeue);
            //iterating queue elements using enumerator method
            Queue<string>.Enumerator enumarator = queue.GetEnumerator();
            while (enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current);
            }
        }
    }
}