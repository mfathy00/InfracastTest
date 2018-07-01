using System;
using InfracastTest.Interfaces;
using InfracastTest.Services;

namespace InfracastTest
{
    class Program
    {

        static void Main(string[] args)
        {
            ICodeParser codeParser = new CodeParser();
            Console.WriteLine("TotalBlocks: "+ codeParser.GetTotalBlocks());
            Console.WriteLine("TotalStatments: " + codeParser.GetTotalStatments());
            Console.WriteLine("totalExpressions: " + codeParser.GetTotalExperession());

            Console.ReadLine();
        }



    }
}
