
namespace Patterns.Builder
{
    public class Creation
    {
        public bool IsValue { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "IsValue - " + IsValue + 
                    "\nNumber - " + Number + 
                    "\nName - " + Name;
        }
    }
}
