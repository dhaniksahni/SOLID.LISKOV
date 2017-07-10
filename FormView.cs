using SOLID.LISKOV.RefectorCode;
using SOLID.LISKOV.WithoutRefector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOLID.LISKOV
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void btnCustomerDiscount_Click(object sender, EventArgs e)
        {
            ICustomer objIcust;
            List<ICustomer> listcust = new List<ICustomer>();

            objIcust = new WithoutRefector.PaidCustomerSalesEnity();
            objIcust.CustomerName = "Paid Customer";
            objIcust.CustomerCode = 001;
            objIcust.ProductQuantity = 5;
            objIcust.ProductRate = 20;
            listcust.Add(objIcust);

            objIcust = new WithoutRefector.FreeCustomerSalesEnity();
            objIcust.CustomerName = "Free Customer";
            objIcust.CustomerCode = 002;
            objIcust.ProductQuantity = 5;
            objIcust.ProductRate = 20;
            listcust.Add(objIcust);

            string printinvoice = "";

            foreach (ICustomer iCust in listcust)
            {
                double amount = iCust.GetDiscount();
                printinvoice = iCust.PrintInvoice(amount);
                lstCustomerDiscount.Items.Add("Invoice Report –> " + printinvoice);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IPaidCustomer objIcust;
            List<IFreeCustomer> listcust = new List<IFreeCustomer>();

            objIcust = new RefectorCode.PaidCustomerSalesEnity();
            objIcust.CustomerName = "Paid Customer";
            objIcust.CustomerCode = 001;
            objIcust.ProductQuantity = 5;
            objIcust.ProductRate = 20;
            listcust.Add(objIcust);

            IFreeCustomer obj = new FreeCustomerSalesEntity();
            obj.CustomerName = "Free Customer";
            obj.CustomerCode = 002;
            listcust.Add(obj);

            string printinvoice = "";

            foreach (IFreeCustomer iCust in listcust)
            {
               lstCustomerDiscount.Items.Add("Invoice Report –> " + printinvoice);
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }
    }
}
