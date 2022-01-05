namespace ConsoleDesignPatterns.Visitor.School
{
    public class Doctor : IVisitor
    {
        public string Name { get; set; }
        public Doctor(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Doctor: " + Name + " did the health checkup of the child: " + kid.KidName);
        }
    }
}
