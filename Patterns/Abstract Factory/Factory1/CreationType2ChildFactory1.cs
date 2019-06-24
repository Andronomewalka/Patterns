using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Factory1
{
    public class CreationType2ChildFactory1 : ICreationType
    {
        public void Foo() => Console.WriteLine("From CreationType2_ChildFactory1");
    }
}
