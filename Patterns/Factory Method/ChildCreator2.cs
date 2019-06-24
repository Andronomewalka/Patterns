using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    class ChildCreator2 : ParentCreator
    {
        private Creation2 Object;

        public override IProduct GetThis() => Object ?? Create();
        public override IProduct Create()
        {
            Object = new Creation2();
            return Object;
        }
    }
}
