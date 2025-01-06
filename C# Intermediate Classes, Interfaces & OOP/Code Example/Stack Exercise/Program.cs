using System.Collections;

namespace Stack_Exercise
{

    public class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();

            int ini = 1;
            int max = 5;

            for (int i = ini; i <= max; i++)
                _stack.Push(i);

            for (int i = ini; i <= max; i++)
                Console.WriteLine(_stack.Pop());

            Console.WriteLine();
        }
    }
}
