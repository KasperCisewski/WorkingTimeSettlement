using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WorkingTimeSettlement.Services
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
