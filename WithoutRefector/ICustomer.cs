namespace SOLID.LISKOV.WithoutRefector
{
    public interface ICustomer
    {
        string CustomerName { set; get; }
        int CustomerCode { set; get; }
        int ProductQuantity { set; get; }
        double ProductRate { set; get; }
        CustomerType CustomerType { get; }
        double GetDiscount();
        string PrintInvoice(double _amount);
    }
}
