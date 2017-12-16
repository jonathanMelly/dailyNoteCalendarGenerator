using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarGenerator
{
    public class Repository
    {
        private const string DB_FILE = "calendar.db";
        private SQLiteConnection connection;
        public void Init()
        {
            connection = new SQLiteConnection("Data Source=" + DB_FILE, false);
            connection.Open();

            using (entity.mainEntities1 ef = new entity.mainEntities1())
            {
                ef.image.First();
            }
        }

        public void Shutdown()
        {
            connection.Close();
        }

        

    }
}
