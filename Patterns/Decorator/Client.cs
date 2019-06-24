using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Client
    {
        public void Main()
        {
            BaseDecorator decorationCreation = 
                new ChildDecorator2(new ChildDecorator1(new Creation()));
            Console.WriteLine(decorationCreation.Foo());
            Console.ReadLine();
        }
    }
}
