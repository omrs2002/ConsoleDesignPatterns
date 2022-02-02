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

            if(element.GetType().Name ==  "Kid")
            {
                Kid kid = (Kid)element;
                Console.WriteLine("Doctor: " + Name + " did the health checkup of the child: " + kid.Name);
            }
            
            if (element.GetType().Name == "Teacher")
            {
                Teacher techr = (Teacher)element;
                Console.WriteLine("Doctor: " + Name + " did the health checkup of the Teacher: " + techr.Name);
            }
        }

        public void Visit(Teacher element)
        {
            if (element.GetType().Name == "Teacher")
            {
                Teacher teacher = (Teacher)element;
                Console.WriteLine("Doctor: " + Name + " did the health checkup of the Teacher: " + teacher.Name );
            }


        }

    }
}
