
namespace Patterns.Builder
{
    public class CreationBuilder1 : ParentCreationBuilder
    {
        protected override void SetIsValue()
        {
            buildingObject.IsValue = false;
        }

        protected override void SetName()
        {
            buildingObject.Name = "FirstBuilderName";
        }

        protected override void SetNumber()
        {
            buildingObject.Number = 11;
        }
    }
}
