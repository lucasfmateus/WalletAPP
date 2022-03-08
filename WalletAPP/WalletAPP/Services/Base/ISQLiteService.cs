using SQLite;

namespace WalletAPP.Services.Base
{
    public interface ISQLiteService
    {
        SQLiteConnection GetConnection();
    }
}
