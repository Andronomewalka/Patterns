namespace Patterns.Decorator
{
    public class ChildDecorator1 : BaseDecorator
    {
        public ChildDecorator1(IDecorator decorator) : base(decorator) { }
        public ChildDecorator1() : base() { }
        public override string Foo() => ParentDecorator?.Foo() + " From ChildDecorator1 ";
    }
}
