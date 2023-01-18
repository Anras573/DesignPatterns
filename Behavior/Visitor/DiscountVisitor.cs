namespace Behavior.Visitor;

public class DiscountVisitor : IVisitor
{
    public decimal TotalDiscountGiven { get; private set; }
    
    public void Visit(IElement element)
    {
        switch (element)
        {
            case Customer customer:
                VisitCustomer(customer);
                break;
            case Employee employee:
                VisitEmployee(employee);
                break;
        }
    }

    private void VisitCustomer(Customer customer)
    {
        const decimal discountPercentage = 10;
        var discount = customer.AmountOrdered / discountPercentage;
        customer.Discount = discount;

        TotalDiscountGiven += discount;
    }

    private void VisitEmployee(Employee employee)
    {
        var discount = employee.YearsEmployed < 10 ? 100 : 200;
        employee.Discount = discount;
        TotalDiscountGiven += discount;
    }
}