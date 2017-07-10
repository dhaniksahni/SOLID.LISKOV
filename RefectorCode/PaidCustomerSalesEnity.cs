using System;
using SOLID.LISKOV.WithoutRefector;

namespace SOLID.LISKOV.RefectorCode
{
    public class PaidCustomerSalesEnity : IPaidCustomer
    {
        private string _customername;
        private int _customercode;
        private int _productquantity;
        private double _productrate;
        public CustomerType CustomerType
        {
            get
            {
                return CustomerType.Paid;
            }
        }
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

        public double GetDiscount()
        {
            if (CustomerType == CustomerType.Paid)
            {
                double rate = ProductQuantity * ProductRate;

                double discountamount = 0;
                double disrate = 20;

                discountamount = (disrate / 100) * rate;
                rate = rate - discountamount;

                return rate;
            }
            return 0;
        }

        public string PrintInvoice(double _amount)
        {
            return "Product Invoice For Customer " + CustomerName + " with Total Amount " + _amount;
        }
    }
}

