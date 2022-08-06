using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input string:");
            string str = Console.ReadLine();
            if (IsValid2(str) == true) Console.WriteLine("Full complect");
            else Console.WriteLine("Non complect");

            Console.ReadKey();

            bool IsValid2(string s)
            {
                var stack = new Stack<char>();
                foreach (var c in s)
                {
                    switch (c)
                    {
                        case '{':
                        case '(':
                        case '[':
                            stack.Push(c);
                            break;
                        case '}':
                            if (stack.Count == 0) return false;
                            if (stack.Pop() != '{') return false;
                            break;
                        case ']':
                            if (stack.Count == 0) return false;
                            if (stack.Pop() != '[') return false;
                            break;
                        case ')':
                            if (stack.Count == 0) return false;
                            if (stack.Pop() != '(') return false;
                            break;
                    }
                }
                Console.WriteLine("0-st  Count: {0}", stack.Count);
                return stack.Count == 0;
            }
        }
    }
}
