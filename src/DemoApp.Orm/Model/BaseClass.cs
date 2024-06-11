using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DemoApp.Orm.Model
{

    [NonPersistent]
    public abstract class BaseClass : XPObject
    {
        public BaseClass()
        {
        }

        public BaseClass(Session session) : base(session)
        {
        }

        public BaseClass(Session session, XPClassInfo classInfo) : base(session, classInfo)
        {
        }
    }
}