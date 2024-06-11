using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Orm.Model
{
    using DevExpress.Xpo;
    using System;

    public class DataTypesClass : BaseClass
    {
        public DataTypesClass(Session session) : base(session) { }

        private bool _BooleanProp;
        public bool BooleanProp
        {
            get { return _BooleanProp; }
            set { SetPropertyValue(nameof(BooleanProp), ref _BooleanProp, value); }
        }

        private byte _ByteProp;
        public byte ByteProp
        {
            get { return _ByteProp; }
            set { SetPropertyValue(nameof(ByteProp), ref _ByteProp, value); }
        }

        private sbyte _SByteProp;
        public sbyte SByteProp
        {
            get { return _SByteProp; }
            set { SetPropertyValue(nameof(SByteProp), ref _SByteProp, value); }
        }

        private char _CharProp;
        public char CharProp
        {
            get { return _CharProp; }
            set { SetPropertyValue(nameof(CharProp), ref _CharProp, value); }
        }

        private decimal _DecimalProp;
        public decimal DecimalProp
        {
            get { return _DecimalProp; }
            set { SetPropertyValue(nameof(DecimalProp), ref _DecimalProp, value); }
        }

        private double _DoubleProp;
        public double DoubleProp
        {
            get { return _DoubleProp; }
            set { SetPropertyValue(nameof(DoubleProp), ref _DoubleProp, value); }
        }

        private float _SingleProp;
        public float SingleProp
        {
            get { return _SingleProp; }
            set { SetPropertyValue(nameof(SingleProp), ref _SingleProp, value); }
        }

        private short _Int16Prop;
        public short Int16Prop
        {
            get { return _Int16Prop; }
            set { SetPropertyValue(nameof(Int16Prop), ref _Int16Prop, value); }
        }

        private ushort _UInt16Prop;
        public ushort UInt16Prop
        {
            get { return _UInt16Prop; }
            set { SetPropertyValue(nameof(UInt16Prop), ref _UInt16Prop, value); }
        }

        private int _Int32Prop;
        public int Int32Prop
        {
            get { return _Int32Prop; }
            set { SetPropertyValue(nameof(Int32Prop), ref _Int32Prop, value); }
        }

        private uint _UInt32Prop;
        public uint UInt32Prop
        {
            get { return _UInt32Prop; }
            set { SetPropertyValue(nameof(UInt32Prop), ref _UInt32Prop, value); }
        }

        private long _Int64Prop;
        public long Int64Prop
        {
            get { return _Int64Prop; }
            set { SetPropertyValue(nameof(Int64Prop), ref _Int64Prop, value); }
        }

        private ulong _UInt64Prop;
        public ulong UInt64Prop
        {
            get { return _UInt64Prop; }
            set { SetPropertyValue(nameof(UInt64Prop), ref _UInt64Prop, value); }
        }

        private Guid _GuidProp;
        public Guid GuidProp
        {
            get { return _GuidProp; }
            set { SetPropertyValue(nameof(GuidProp), ref _GuidProp, value); }
        }

        private string _StringProp;
        public string StringProp
        {
            get { return _StringProp; }
            set { SetPropertyValue(nameof(StringProp), ref _StringProp, value); }
        }

        private DateTime _DateTimeProp;
        public DateTime DateTimeProp
        {
            get { return _DateTimeProp; }
            set { SetPropertyValue(nameof(DateTimeProp), ref _DateTimeProp, value); }
        }

        private TimeSpan _TimeSpanProp;
        public TimeSpan TimeSpanProp
        {
            get { return _TimeSpanProp; }
            set { SetPropertyValue(nameof(TimeSpanProp), ref _TimeSpanProp, value); }
        }

        private byte[] _ByteArrayProp;
        public byte[] ByteArrayProp
        {
            get { return _ByteArrayProp; }
            set { SetPropertyValue(nameof(ByteArrayProp), ref _ByteArrayProp, value); }
        }
    }


}
