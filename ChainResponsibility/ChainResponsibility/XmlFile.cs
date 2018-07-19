using ChainResponsibility;
using System;

namespace ChainResponsibilty.Tests
{
    public class XmlFile : IParser
    {
        private IParser _parser;

        public void Parse(string fileName)
        {
            if (fileName.Contains(".xml"))
            {
                Console.Write("File should be parsed with .xml");
            }
            else
            {
                Console.Write("File cannot be parsed !!!");
            }
        }

        public void SetSuccessor(IParser nextPasrer)
        {
            _parser = nextPasrer;
        }
    }
}