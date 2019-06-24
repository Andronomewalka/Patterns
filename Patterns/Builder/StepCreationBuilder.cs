using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class StepCreationBuilder
    {
        public Creation BuildingObject { get; private set; }

        public StepCreationBuilder()
        {
            BuildingObject = new Creation();
        }

        public StepCreationBuilder SetIsValue(bool value)
        {
            BuildingObject.IsValue = value;
            return this;
        }
        public StepCreationBuilder SetNumber(int value)
        {
            BuildingObject.Number = value;
            return this;
        }
        public StepCreationBuilder SetName(string value)
        {
            BuildingObject.Name = value;
            return this;
        }
    }
}
