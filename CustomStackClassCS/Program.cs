using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackClassCS
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack<string> stack = new CStack<string>();
            stack.push("Hello");
            stack.push("There");
            stack.push("Bro");
            while (stack.isEmpty() != true)
            {
                Console.WriteLine(stack.pop());
            }

        }
    }
}
