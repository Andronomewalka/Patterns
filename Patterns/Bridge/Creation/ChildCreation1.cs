using Patterns.Bridge.Instrument;

namespace Patterns.Bridge.Creation
{
    public class ChildCreation1 : AbstractCreation
    {
        public ChildCreation1(AbstractInstrument instrument) : base(instrument) { }
        public override string Foo() => "From ChildCreation1" + instrument.WithFoo();
    }
}
