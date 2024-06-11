using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.ComponentModel;

namespace DemoApp.Orm.Model
{
    [DefaultClassOptions()]
    [DefaultProperty(nameof(Name))]
    public class Customer : BaseClass
    {
        private bool active;

        private string address;
        private string code;
        private string email;
        private decimal maxCredit;
        private string name;

        public Customer(Session session) : base(session)
        {
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }


        [Size(100)]
        //[Size(SizeAttribute.Unlimited)]
        public string Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
        }

        public bool Active
        {
            get => active;
            set => SetPropertyValue(nameof(Active), ref active, value);
        }

        public decimal MaxCredit
        {
            get => maxCredit;
            set => SetPropertyValue(nameof(MaxCredit), ref maxCredit, value);
        }

        //[NavigationProperty]
        [Association("Customer-Invoices")]
        public XPCollection<Invoice> Invoices => GetCollection<Invoice>(nameof(Invoices));
    }
}