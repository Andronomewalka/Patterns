
namespace Patterns.Builder
{
    public abstract class ParentCreationBuilder
    {
        protected Creation buildingObject;
        protected abstract void SetIsValue();
        protected abstract void SetNumber();
        protected abstract void SetName();

        public Creation Create()
        {
            buildingObject = new Creation();

            SetIsValue();
            SetNumber();
            SetName();

            return buildingObject;
        }
    }
}
