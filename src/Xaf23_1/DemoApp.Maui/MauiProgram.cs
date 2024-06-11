using BIT.Data.Sync.Xpo;
using BIT.Data.Sync.Xpo.Helpers;
using DemoApp.Orm.Model;
using DevExpress.Data.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace DemoApp.Maui
{
    public static class MauiProgram
    {
        public static SyncFrameworkXpoDefault SyncFrameworkXpoDefault { get; set; }
        public static MauiApp CreateMauiApp()
        {
            SyncDataStore.Register();
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            
          

            return builder.Build();
        }




    }
}
