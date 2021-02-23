using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings curr = new StackOfStrings();

            Console.WriteLine(string.Join(" ", curr.AddRange(new List<string> { "Go6o", "Gogi", "Pesho" })));
        }
    }
}
