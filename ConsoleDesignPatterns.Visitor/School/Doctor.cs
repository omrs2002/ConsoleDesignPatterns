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
                Console.WriteLine("Doctor: " + Name + " did the health checkup of the child: " + kid.KidName);
            }
            
            if (element.GetType().Name == "Teacher")
            {
                Teacher kid = (Teacher)element;
                Console.WriteLine("Doctor: " + Name + " did the health checkup of the Teacher: " + kid.TeacherName);
            }


        }


        public void Visit(Teacher element)
        {
            if (element.GetType().Name == "Teacher")
            {
                Teacher kid = (Teacher)element;
                Console.WriteLine("Doctor: " + Name + " did the health checkup of the Teacher: " + kid.TeacherName);
            }


        }

    }
}
