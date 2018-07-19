using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility
{
    public interface IParser
    {
        void Parse(string fileName);
        void SetSuccessor(IParser nextPasrer);
    }
}
