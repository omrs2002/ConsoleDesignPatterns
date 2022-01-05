using ConsoleDesignPatterns.Visitor.Employees;
using ConsoleDesignPatterns.Visitor.School;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main(string[] args)
    {

        var host = new HostBuilder()
       .ConfigureServices(services =>
       {



       })
       .Build();

        //SchoolVisitor();
        EmployeeVisitor();


    }

    private static void EmployeeVisitor()
    {

        // Setup employee collection
        Employees employee = new Employees();
        employee.Attach(new Clerk());
        employee.Attach(new Director());
        employee.Attach(new President());
        // Employees are 'visited'
        employee.Accept(new IncomeVisitor());
        employee.Accept(new VacationVisitor());
        // Wait for user
        Console.ReadKey();



    }

    private static void SchoolVisitor()
    {
        var school = new School();
        var visitor1 = new Doctor("James");
        school.PerformOperation(visitor1);
        Console.WriteLine();
        var visitor2 = new Salesman("John");
        school.PerformOperation(visitor2);
        Console.Read();
    }
}