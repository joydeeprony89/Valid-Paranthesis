using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParenthesis("({[]}))"));
        }

        public static bool ValidParenthesis(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if (c == '(') stack.Push(')');
                else if (c == '{') stack.Push('}');
                else if (c == '[') stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != c) return false;
            }
            return stack.Count == 0;
        }
    }
}
