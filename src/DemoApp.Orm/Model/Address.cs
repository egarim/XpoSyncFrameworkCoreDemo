using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DemoApp.Orm.Model
{
    [DefaultClassOptions()]
    public class Address : BaseClass
    {
        byte[] data;
        string longAddressText;
        int testKey;
        private string city;
        private bool main;



        private string state;
        private string stree;


        //[Key(false)]
        //public int TestKey
        //{
        //    get => testKey;
        //    set => SetPropertyValue(nameof(TestKey), ref testKey, value);
        //}

        public Address(Session session) : base(session)
        {
        }

        public bool Main
        {
            get => main;
            set => SetPropertyValue(nameof(Main), ref main, value);
        }

        [Size(SizeAttribute.Unlimited)]
        public string LongAddressText
        {
            get => longAddressText;
            set => SetPropertyValue(nameof(LongAddressText), ref longAddressText, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Street
        {
            get => stree;
            set => SetPropertyValue(nameof(Street), ref stree, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string City
        {
            get => city;
            set => SetPropertyValue(nameof(City), ref city, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string State
        {
            get => state;
            set => SetPropertyValue(nameof(State), ref state, value);
        }

        public byte[] Data
        {
            get => data;
            set => SetPropertyValue(nameof(Data), ref data, value);
        }
    }
}