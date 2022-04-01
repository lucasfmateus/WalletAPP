using SQLite;
using System;
using System.IO;
using WalletAPP.Services.Base;

namespace WalletAPP.iOS.Services
{
    class SQLiteService_iOS : ISQLiteService
    {
        private SQLiteConnection connection;

        public void Dispose()
        {
            connection.Dispose();
        }

        public SQLiteConnection GetConnection()
        {
            try
            {
                if (connection == null)
                {
                    var filename = "infinitusapp.db";

                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                    string libraryPath = Path.Combine(folder, filename);

                    connection = new SQLiteConnection(libraryPath);
                }

                return connection;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}