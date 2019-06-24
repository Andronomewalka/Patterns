namespace Patterns.Decorator
{
    public abstract class BaseDecorator : IDecorator
    {
        protected IDecorator ParentDecorator { get; set; }
        protected BaseDecorator(IDecorator decorator) => ParentDecorator = decorator;
        protected BaseDecorator() => ParentDecorator = null;
        public abstract string Foo();
    }
}
