namespace ConsoleDesignPatterns.Visitor.School
{
    public class Teacher : IElement
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }







}
