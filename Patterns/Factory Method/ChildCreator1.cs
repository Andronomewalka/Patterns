using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    class ChildCreator1 : ParentCreator
    {
        private Creation1 Object;

        public override IProduct GetThis() => Object ?? Create();
        public override IProduct Create()
        {
            Object =  new Creation1();
            return Object;
        }
    }
}
