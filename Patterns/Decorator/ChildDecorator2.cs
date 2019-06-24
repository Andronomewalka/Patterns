namespace Patterns.Decorator
{
    public class ChildDecorator2 : BaseDecorator
    {
        public ChildDecorator2(IDecorator decorator) : base(decorator) { }
        public ChildDecorator2() : base() { }
        public override string Foo() => ParentDecorator?.Foo() + " From ChildDecorator2 ";
    }
}
