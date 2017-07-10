namespace SOLID.LISKOV.RefectorCode
{
    public interface IPaidCustomer : IFreeCustomer, IDiscount
    {
        int ProductQuantity { get; set; }
        double ProductRate { get; set; }
        string PrintInvoice(double _amount);
    }
}
