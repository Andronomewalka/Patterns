using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public abstract class AbstractFamilyFactory
    {
        public void CreateAll()
        {
            CreateType1().Foo();
            CreateType2().Foo();
        }

        protected abstract ICreationType CreateType1();
        protected abstract ICreationType CreateType2();
    }
}
