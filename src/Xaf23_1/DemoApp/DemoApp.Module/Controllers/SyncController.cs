using BIT.Data.Sync.Xaf;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Module.Controllers
{
    public class SyncController: XafSyncControllerBase
    {
        SimpleAction EnableTracking;
        DevExpress.ExpressApp.IObjectSpace objectSpace;
        /// <summary>
        /// <para>Creates an instance of the <see cref="SyncController"/> class.</para>
        /// </summary>
        public SyncController()
        {
            EnableTracking = new SimpleAction(this, nameof(EnableTracking), "View");
            EnableTracking.Execute += EnableTracking_Execute;
            
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            objectSpace = this.View.ObjectSpace;
            SetCaption(objectSpace);
        }
        private void EnableTracking_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            objectSpace = this.Application.CreateObjectSpace();
            objectSpace.EnableDeltaTracking(!objectSpace.GetEnableDeltaTrackingState());
            SetCaption(objectSpace);
        }
        void SetCaption(DevExpress.ExpressApp.IObjectSpace objectSpace)
        {
            if(objectSpace.GetEnableDeltaTrackingState())
            {
                EnableTracking.Caption = "Disable Delta Tracking";
            }
            else
            {
                EnableTracking.Caption = "Enable Delta Tracking";
            }
        }
    }
}
