using System;

namespace Patterns.Builder
{
    class Client
    {
        public void Main()
        {
            ParentCreationBuilder builder = new CreationBuilder2();
            Creation some = builder.Create();
            Console.WriteLine(some);

            //StepCreationBuilder stepBuilder = new StepCreationBuilder();
            //stepBuilder
            //    .SetIsValue(true)
            //    .SetName("StepCreationName")
            //    .SetNumber(33);
            //
            //Creation any = stepBuilder.BuildingObject;
            //Console.WriteLine(any);

            Console.ReadLine();
        }
    }
}
