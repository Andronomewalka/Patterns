using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Factory1
{
    public class CreationType1ChildFactory1 : ICreationType
    {
        public void Foo() => Console.WriteLine("From CreationType1_ChildFactory1");
    }
}
