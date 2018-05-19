using System;
using System.Data;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Helpers;

namespace WinWebSolution.Module {
    //For demo purposes only!!!
    public class CodeCentralExampleInMemoryDataStoreProvider {
        public const string XpoProviderTypeString = "CodeCentralExampleInMemoryDataSet";
        public const string ConnectionString = "XpoProvider=CodeCentralExampleInMemoryDataSet";
        private static DataSet dataSet;
        private static bool isRegistered;

        static CodeCentralExampleInMemoryDataStoreProvider() {
            if (!isRegistered) {
                try {
                    dataSet = new DataSet();
                    DataStoreBase.RegisterDataStoreProvider(XpoProviderTypeString, new DataStoreCreationFromStringDelegate(CreateProviderFromString));
                    isRegistered = true;
                } catch {
                    throw new Exception(string.Format("Cannot register the {0}", typeof(CodeCentralExampleInMemoryDataStoreProvider).Name));
                }
            }
        }
        public static IDataStore CreateProviderFromString(string connectionString, AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect) {
            objectsToDisposeOnDisconnect = new IDisposable[] { };
            return new DataSetDataStore(dataSet, autoCreateOption);
        }
        public static void Register() { }
    }
}