using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PackageTracker {
    class Database {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PackageTracker"].ToString();

    }
}
