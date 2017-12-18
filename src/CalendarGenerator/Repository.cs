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
        private const string CONNECTION_STRING = "Data Source=" + DB_FILE;

        private string language = "fr";

        public string Language { get; set; }

        public void Ping()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                connection.Open();
                connection.Close();
            }

        }

        public List<Note> GetNotes()
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT note.author,note_text.content,note.generic_image FROM " +
                        "note LEFT JOIN note_text ON note_text.note_id=note.id LEFT JOIN language ON note_text.language_id=language.id " +
                        "WHERE language.name='" + language + "'";

                    Enumerable enumerable = (SQLDataReader) command.ExecuteReader().
                    foreach(IDataReader element in command.ExecuteReader().asen)
                    {

                    }
                }
            }
        }

        public int ExecuteRawSQL(string sql)
        {
            using (IDbConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    return command.ExecuteNonQuery();
                }
            }
        }



    }
}
