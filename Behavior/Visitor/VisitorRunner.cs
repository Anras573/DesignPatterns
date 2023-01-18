using Common;

namespace Behavior.Visitor;

public class VisitorRunner : IRunner
{
    public string Name => nameof(VisitorRunner);
    public void Run()
    {
        var employees = new List<Employee>
        {
            new ("Malcolm", 15),
            new ("Neal", 2)
        };

        var customers = new List<Customer>
        {
            new ("Giselle", 1000),
            new ("Chloe", 800),
            new ("Houston", 500)
        };

        var visitor = new DiscountVisitor();

        employees.ForEach(e => e.Accept(visitor));
        customers.ForEach(c => c.Accept(visitor));
        
        Console.WriteLine($"Total discount given: {visitor.TotalDiscountGiven}");
    }
}