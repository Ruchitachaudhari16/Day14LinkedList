using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC2:- Ability to create LinkedList by adding 30 and 56 to 70
            LinkedListNode list = new LinkedListNode();
            Console.WriteLine("SimpleLinked List Created");
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.ReadLine();
        }
    }
}
