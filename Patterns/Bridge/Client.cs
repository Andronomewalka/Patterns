using Patterns.Bridge.Creation;
using Patterns.Bridge.Instrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class Client
    {
        public void Main()
        {
            ChildCreation1 creation1 = new ChildCreation1(new ChildInstrument2());
            ChildCreation2 creation2 = new ChildCreation2(new ChildInstrument1());
            
            Console.WriteLine(creation1.Foo());
            Console.WriteLine(creation2.Foo());
            Console.ReadLine();
        }
    }
}
