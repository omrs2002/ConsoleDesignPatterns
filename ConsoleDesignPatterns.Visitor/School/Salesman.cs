namespace ConsoleDesignPatterns.Visitor.School
{
    class Salesman : IVisitor
    {
        public string Name { get; set; }
        public Salesman(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + Name + " gave the school bag to the child: " + kid.KidName);
        }
    }






}
