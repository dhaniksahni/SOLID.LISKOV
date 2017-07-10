using System;
using SOLID.LISKOV.WithoutRefector;

namespace SOLID.LISKOV.RefectorCode
{
    class FreeCustomerSalesEntity : IFreeCustomer
    {

        private string _customername;
        private int _customercode;
        private int _productquantity;
        private double _productrate;

        public string CustomerName
        {
            set { _customername = value; }
            get { return _customername; }
        }

        public int CustomerCode
        {
            set { _customercode = value; }
            get { return _customercode; }
        }

        public int ProductQuantity
        {
            set { _productquantity = value; }
            get { return _productquantity; }
        }

        public double ProductRate
        {
            set { _productrate = value; }
            get { return _productrate; }
        }

        public CustomerType CustomerType
        {
            get
            {
               return  CustomerType.Free;
            }            
        }
    }
}
