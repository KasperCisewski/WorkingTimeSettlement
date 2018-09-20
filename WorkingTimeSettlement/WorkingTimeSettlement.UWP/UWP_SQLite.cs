using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using SQLite;
using WorkingTimeSettlement.Services;
using WorkingTimeSettlement.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(UWP_SQLite))]
namespace WorkingTimeSettlement.UWP
{
    public class UWP_SQLite:ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "WorkingDays.db3";
            var path = Path.Combine(ApplicationData.
                Current.LocalFolder.Path, dbName);
            return new SQLiteConnection(path);
        }
    }
}
