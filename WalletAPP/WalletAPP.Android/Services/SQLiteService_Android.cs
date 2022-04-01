using SQLite;
using System;
using System.IO;
using WalletAPP.Services.Base;

namespace WalletAPP.Droid.Services
{
    class SQLiteService_Android : ISQLiteService, IDisposable
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
                    var fileName = string.Concat("infinitusapp", ".db");

                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName);

                    connection = new SQLiteConnection(path);
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