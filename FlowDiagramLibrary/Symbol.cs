using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramLibrary
{
    public class Symbol
    {
        public string name;

        public string Name { get => name; set => name = value; }

        public Symbol()
        {
            this.name = "";
        }


        public Symbol(String name)
        {
            this.name = name;
        }
    }
}
