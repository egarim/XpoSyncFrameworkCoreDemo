using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace DemoApp.Orm.Model
{
    [DefaultClassOptions()]
    public class InvoiceDetail : BaseClass
    {
        private Invoice invoice;
        private Product product;
        private int quatity;

        private decimal total;
        private decimal unitPrice;

        public InvoiceDetail(Session session) : base(session)
        {
        }


        [Association("Invoice-InvoiceDetails"), NoForeignKey()]
        public Invoice Invoice
        {
            get => invoice;
            set => SetPropertyValue(nameof(Invoice), ref invoice, value);
        }


        [Association("Product-InvoiceDetails"), NoForeignKey()]
        public Product Product
        {
            get => product;
            set => SetPropertyValue(nameof(Product), ref product, value);
        }

        public decimal UnitPrice
        {
            get => unitPrice;
            set => SetPropertyValue(nameof(UnitPrice), ref unitPrice, value);
        }

        public int Quatity
        {
            get => quatity;
            set => SetPropertyValue(nameof(Quatity), ref quatity, value);
        }

        public decimal Total
        {
            get => total;
            set => SetPropertyValue(nameof(Total), ref total, value);
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (IsLoading)
                return;

            if (propertyName == nameof(Product) || propertyName == nameof(Quatity) || propertyName == nameof(UnitPrice))
            {
                if (Product != null)
                    UnitPrice = Product.UnitPrice;

                Total = UnitPrice * Quatity;
            }
        }
    }
}