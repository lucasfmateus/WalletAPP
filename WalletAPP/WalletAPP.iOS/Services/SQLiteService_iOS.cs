using Foundation;
using WalletAPP.Services.Base;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;

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