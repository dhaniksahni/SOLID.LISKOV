using SOLID.LISKOV.WithoutRefector;

namespace SOLID.LISKOV.RefectorCode
{
    public interface IFreeCustomer
    {
        string CustomerName { set; get; }
        int CustomerCode { set; get; }
        CustomerType CustomerType { get; }       
    }
}
