namespace Behavior.Visitor;

public class Customer : IElement
{
    public string Name { get; }
    public decimal AmountOrdered { get; }
    public decimal Discount { get; set; }

    public Customer(string name, decimal amountOrdered)
    {
        Name = name;
        AmountOrdered = amountOrdered;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        Console.WriteLine($"Visited {nameof(Customer)} {Name}, discount given: {Discount}");
    }
}