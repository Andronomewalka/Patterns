using Patterns.Abstract_Factory.Factory1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    class Client
    {
        public void SomeExternalOpertion(AbstractFamilyFactory obj) => obj.CreateAll();
        public void Main()
        {
            // SomeExternalOpertion(new Child1FamilyFactory());
            SomeExternalOpertion(new Child2FamilyFactory());
            Console.ReadLine();
        }
    }
}
