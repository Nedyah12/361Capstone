using MySql.Data.MySqlClient;

namespace OnlineStore.Accessors {
    interface IDatabaseConnection {
        MySqlConnection getConnection();
    }
}
