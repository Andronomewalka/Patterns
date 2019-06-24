using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class CreationType1ChildFactory2 : ICreationType
    {
        public void Foo() => Console.WriteLine("From CreationType1_ChildFactory2");
    }
}
