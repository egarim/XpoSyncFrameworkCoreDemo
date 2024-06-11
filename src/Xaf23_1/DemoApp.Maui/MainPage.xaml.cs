using BIT.Data.Sync.Xpo.Helpers;
using DemoApp.Orm.Model;
using DevExpress.Xpo;
using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace DemoApp.Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.ServerUrl.Text = "https://f1ba-89-117-53-109.ngrok-free.app";
        }

        private async void OnPush(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = MauiProgram.SyncFrameworkXpoDefault.CreateUnitOfWok();
            var Ds= unitOfWork.GetSyncDataStore();
            var Deltas=await Ds.DeltaStore.GetDeltasAsync("-1",default);
            var PushResponse= await unitOfWork.PushAsync();
            
        }
        private async void OnComplexTransaction(object sender, EventArgs e)
        {
            var UoW = MauiProgram.SyncFrameworkXpoDefault.CreateUnitOfWok();
            Updater updater = new Updater();
            updater.GenerateData(UoW);
            UoW.CommitChanges();

        

            var TestUoW=MauiProgram.SyncFrameworkXpoDefault.CreateUnitOfWok();
            var Customers=TestUoW.Query<Customer>().ToList();
            foreach (Customer customer in Customers)
            {
                Debug.WriteLine(customer.Name); 
            }

        }
        private async void OnPull(object sender, EventArgs e)
        {
           var PullResponse= await MauiProgram.SyncFrameworkXpoDefault.CreateUnitOfWok().PullAsync();

        
        }
        private async void Save(object sender, EventArgs e)
        {
            //var Context = await InitSyncFramework(this.ServerUrl.Text);
            //Blog blog = new Blog
            //{
            //    Name = this.BlogName.Text,
            //};
            //Context.Add(blog);
            //await Context.SaveChangesAsync();
            //Items.Add(blog);
            //this.BlogName.Text = "";

        }

        private async void OnInitSyncFrameworkBtn(object sender, EventArgs e)
        {
           
            this.ServerUrlLabel.Text = this.ServerUrl.Text;

            string DataFile = Path.Combine(FileSystem.AppDataDirectory, "XpoData.db3");
            string DeltaFile = Path.Combine(FileSystem.AppDataDirectory, "XpoDelta.db3");

            MauiProgram.SyncFrameworkXpoDefault = new SyncFrameworkXpoDefault();
            MauiProgram.SyncFrameworkXpoDefault.InitSyncFrameworkWithSQLiteDatabases("Maui", "Server", this.ServerUrl.Text, string.Empty, DataFile, DeltaFile, typeof(Customer).Assembly);
            await DisplayAlert("SyncFramework", "Initialized", "OK");
        }
   
    }

}
