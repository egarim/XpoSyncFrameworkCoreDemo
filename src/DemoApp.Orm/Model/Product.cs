using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace DemoApp.Orm.Model
{
    [DefaultClassOptions()]
    public class Product : BaseClass
    {
        private string code;
        private string description;

        private bool discontinued;
        private string name;
        private decimal unitPrice;

        public Product(Session session) : base(session)
        {
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }

        public decimal UnitPrice
        {
            get => unitPrice;
            set => SetPropertyValue(nameof(UnitPrice), ref unitPrice, value);
        }

        [Association("Product-InvoiceDetails")]
        public XPCollection<InvoiceDetail> InvoiceDetails => GetCollection<InvoiceDetail>(nameof(InvoiceDetails));

        public bool Discontinued
        {
            get => discontinued;
            set => SetPropertyValue(nameof(Discontinued), ref discontinued, value);
        }
    }
}