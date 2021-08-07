using System;

namespace ValuesAdderFromText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\consc\source\ValuesAdderFromText\ValuesAdderFromText\values.txt");
            
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Adding contents of values.txt.");
            var sum = 0.0;
            foreach (string line in lines)
            {
                sum += Convert.ToDouble(line);
                Console.WriteLine("...");
            }
            Console.WriteLine($"...sum: {sum.ToString("C")}");
        }
    }
}