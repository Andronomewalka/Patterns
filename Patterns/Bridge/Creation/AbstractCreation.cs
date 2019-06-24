using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Bridge.Instrument;

namespace Patterns.Bridge.Creation
{
    public abstract class AbstractCreation
    {
        protected AbstractInstrument instrument;
        public AbstractCreation(AbstractInstrument instrument) => this.instrument = instrument;
        public abstract string Foo();
    }
}