using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Creation : IDecorator
    {
        public string Foo() => " From creation ";
    }
}
