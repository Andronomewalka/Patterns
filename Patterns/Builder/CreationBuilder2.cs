
namespace Patterns.Builder
{
    public class CreationBuilder2 : ParentCreationBuilder
    {
        protected override void SetIsValue()
        {
            buildingObject.IsValue = true;
        }

        protected override void SetName()
        {
            buildingObject.Name = "SecondBuilderName";
        }

        protected override void SetNumber()
        {
            buildingObject.Number = 22;
        }
    }
}
