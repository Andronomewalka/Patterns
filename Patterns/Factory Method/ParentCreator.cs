using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    public abstract class ParentCreator
    {
        public abstract IProduct Create();
        public abstract IProduct GetThis();

        public string AbstractFoo()
        {
            var cur = GetThis();
            return cur.Foo();
        }
    }
}
