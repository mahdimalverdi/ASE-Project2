using Project2.Abstraction;

namespace Project2.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        internal string Serialize(IVisitor visitor)
        {
            return visitor.GetTitle(this);
        }
    }
}
