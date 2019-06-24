using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    class Child2FamilyFactory : AbstractFamilyFactory
    {
        protected override ICreationType CreateType1()
        {
            return new CreationType1ChildFactory2();
        }

        protected override ICreationType CreateType2()
        {
            return new CreationType2ChildFactory2();
        }
    }
}
