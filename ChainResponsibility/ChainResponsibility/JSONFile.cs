using ChainResponsibility;
using System;

namespace ChainResponsibilty.Tests
{
    public class JSONFile :IParser
    {
        private IParser _parser;
        public void Parse(string fileName)
        {
            if (fileName.Contains(".json"))
            {
                Console.Write("File should be parsed with .json");
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