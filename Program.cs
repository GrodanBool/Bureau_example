using System;

class Program
{
    static void Main(string[] args)
    {
        string contents = "";

        System.Console.WriteLine("Öppnar byrålåddan...");

        while (true)
        {
            System.Console.Write("Vill du lägga nåt i låddan?: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q" || input.ToLower() == "inget")
            {
                Console.WriteLine("Stänger byrån...");
                Environment.Exit(0);
            }
            else if (input.ToLower() == "t" || input.ToLower() == "töm")
            {
                System.Console.WriteLine("Tar ut " + contents);
                contents = "";
            }
            else
            {
                if (contents.Length == 0)
                {
                    contents = input.Trim();
                }
                else
                {
                    contents = contents + " och " + input.Trim();
                }
            }

            Console.WriteLine($"Byrån innehåller nu {contents}");
        }
    }
}