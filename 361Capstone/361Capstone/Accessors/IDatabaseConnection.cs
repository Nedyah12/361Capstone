using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    interface IDatabaseConnection {
        MySqlConnection getConnection();
    }
}
