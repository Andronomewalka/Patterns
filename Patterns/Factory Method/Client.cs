using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    class Client
    {
        public string SomeExternalOpertion(ParentCreator obj) => obj.AbstractFoo();
        public void Main()
        {
            Console.WriteLine(SomeExternalOpertion(new ChildCreator1()));
            Console.WriteLine(SomeExternalOpertion(new ChildCreator2()));
            Console.ReadLine();
        }
    }
}
