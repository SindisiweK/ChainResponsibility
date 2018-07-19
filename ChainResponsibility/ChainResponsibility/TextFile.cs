using ChainResponsibility;
using System;

namespace ChainResponsibilty.Tests
{
    public class TextFile : IParser
    {
        private IParser _nextParser;

        private string FileName { get; }

        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.Contains(".txt"))
            {
                Console.Write("File should be parsed with .txt");
            }
            else
            {
                Console.Write("File cannot be parsed !!!");
            }
           
        }
    }
}