using Patterns.Bridge.Instrument;

namespace Patterns.Bridge.Creation
{
    public class ChildCreation2 : AbstractCreation
    {
        public ChildCreation2(AbstractInstrument instrument) : base(instrument) { }
        public override string Foo() => "From ChildCreation2" + instrument.WithFoo();
    }
}
