namespace ConsoleDesignPatterns.Visitor.Employees
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee? employee = element as Employee;
            // Provide 3 extra vacation days
            if(employee is not null) 
            {
                employee.VacationDays += 3;
                Console.WriteLine("{0} {1}'s new vacation days: {2}",
                employee.GetType().Name, employee.Name,
                employee.VacationDays);
            }
        }
    }

}
