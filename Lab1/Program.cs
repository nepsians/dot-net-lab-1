using System;

namespace Lab1
{
    class Program
    {
        static void ReadLineExample()
        {
            Console.Write("Input: ");
            String? input = Console.ReadLine();
            Console.Write("Output: " + input);
            Console.ReadKey();
        }

        static void ReadExample()
        {
            Console.Write("Input: ");
            Char? input = Convert.ToChar(Console.Read());
            Console.Write("Output: " + input);
            Console.ReadKey();
        }

        static void WriteExample()
        {
            Console.Write("I am students");
            Console.Write(" of ");
            Console.Write("DAV College");
            Console.ReadKey();
        }

        static void WriteLineExample()
        {
            Console.WriteLine("I am students ");
            Console.WriteLine("of");
            Console.WriteLine("DAV College");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // ReadLineExample();

            // ReadExample();

            // WriteExample();

            WriteLineExample();
        }
    }
}