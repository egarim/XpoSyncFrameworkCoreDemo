# BIT.Data.Sync.Xpo

This repository contains the main project `BIT.Data.Sync.Xpo`, which is a powerful tool for synchronizing data using XPO. The other projects in this repository are examples and extensions that demonstrate the usage and extend the functionality of the main project.

## Getting Started

To get started with `BIT.Data.Sync.Xpo`, clone this repository to your local machine.

## XAF integration
- ObjectSpace provider https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.ObjectSpaceProvider

## MAUI,Desktop,Console and others

```<language>
    #region SyncFramework

        static IDataStore? syncDataStoreProvider;
        static ThreadSafeDataLayer Dal;
        static void InitSyncFramework()
        {
            SyncDataStore.Register();
            string ClientNodeId = "MAUI";// HACK this should be a unique ID, you can add the device information to create a unique ID 
            string ServerNodeId = "DemoServer";
            string ServerUri = "https://fb66-89-117-53-109.ngrok-free.app/";

            string dbPathData = Path.Combine(FileSystem.AppDataDirectory, "Data.db3");
            string dbPathDelta = Path.Combine(FileSystem.AppDataDirectory, "Delta.db3");

            string ExcludedTypes = string.Empty;

            var Cnx = SyncDataStore.GetConnectionString(
                SQLiteConnectionProvider.GetConnectionString(dbPathData),
                SQLiteConnectionProvider.GetConnectionString(dbPathDelta),
                ClientNodeId,
                ExcludedTypes, ServerNodeId, ServerUri, true);


            var objectsToDisposeOnDisconnect = new IDisposable[] { };


            syncDataStoreProvider = SyncDataStore.CreateProviderFromString(Cnx, AutoCreateOption.DatabaseAndSchema, out objectsToDisposeOnDisconnect);

            DatabaseHelper.UpdateSchema(syncDataStoreProvider, (new List<Assembly>() { typeof(Customer).Assembly }).ToArray(), true);

            

            Dal = new ThreadSafeDataLayer(syncDataStoreProvider);
        }
        public static UnitOfWork CreateUnitOfWok()
        {
            return new UnitOfWork(Dal);
        }

        #endregion

```

XAF






Open the solution in Visual Studio and set `BIT.Data.Sync.Xpo` as the startup project.

## Examples and Extensions

This repository also contains several examples and extensions that demonstrate the usage and extend the functionality of `BIT.Data.Sync.Xpo`.

- `Example1`: This project demonstrates...
- `Example2`: This project demonstrates...
- `Extension1`: This extension adds...
- `Extension2`: This extension adds...

## Running the Tests

This solution includes integrated unit tests. To run these tests, use the Test Explorer in Visual Studio.

## Building and Running

To build and run the `BI``T.Data.Sync.Xpo` project, use the Build and Run commands in Visual Studio. The output will be displayed in the Output pane.

## Contributing

We welcome contributions to this project. Please see our [Contributing Guide](CONTRIBUTING.md) for more information.

## License

This project is licensed under the [MIT License](LICENSE.md).

## Contact

If you have any questions or issues, please open an issue in this repository.
