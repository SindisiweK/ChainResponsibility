using System;
using ChainResponsibility;

namespace ChainResponsibilty.Tests
{
    public class CsvFile : IParser
    {
        private IParser parser;

        public void Parse(string fileName)
        {
            if (fileName.Contains(".csv"))
            {
                Console.Write("File should be parsed with .csv");
            }
            else
            {
                Console.Write("File cannot be parsed !!!");
            }
        }

        public void SetSuccessor(IParser nextPasrer)
        {
            parser = nextPasrer;
        }
    }
}