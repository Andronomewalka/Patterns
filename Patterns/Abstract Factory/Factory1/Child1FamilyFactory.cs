using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory.Factory1
{
    class Child1FamilyFactory : AbstractFamilyFactory
    {
        protected override ICreationType CreateType1()
        {
            return new CreationType1ChildFactory1();
        }

        protected override ICreationType CreateType2()
        {
            return new CreationType2ChildFactory1();
        }
    }
}
