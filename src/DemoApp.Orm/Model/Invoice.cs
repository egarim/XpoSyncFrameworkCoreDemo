using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;

namespace DemoApp.Orm.Model
{
    [DefaultClassOptions()]
    public class Invoice : BaseClass
    {
        private Customer customer;
        private DateTime date;

        private InvoiceStatus invoiceStatus;
        private decimal total;

        public Invoice(Session session) : base(session)
        {
        }


        [Association("Customer-Invoices"), NoForeignKey()]
        public Customer Customer
        {
            get => customer;
            set => SetPropertyValue(nameof(Customer), ref customer, value);
        }

        public DateTime Date
        {
            get => date;
            set => SetPropertyValue(nameof(Date), ref date, value);
        }

        public decimal Total
        {
            get => total;
            set => SetPropertyValue(nameof(Total), ref total, value);
        }

        public InvoiceStatus InvoiceStatus
        {
            get => invoiceStatus;
            set => SetPropertyValue(nameof(InvoiceStatus), ref invoiceStatus, value);
        }


        [Association("Invoice-InvoiceDetails")]
        public XPCollection<InvoiceDetail> InvoiceDetails => GetCollection<InvoiceDetail>(nameof(InvoiceDetails));
    }
}