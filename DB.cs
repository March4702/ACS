using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS
{
    internal class DB
    {
        public static SQLiteConnection Conn = new SQLiteConnection("Data Source=PPL.DB;Version=3;");

        //public static SQLiteDataAdapter da;
        //public static SQLiteDataReader dr;
        public static DataTable dt;
        public static SQLiteCommand cmd;


        public static void OpenConnection()
        {
            try
            {
                Conn.Open();
                //MessageBox.Show("Connected to SQLite!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public static void CloseConnection()
        {
            Conn.Close();
            //MessageBox.Show("Closed SQLite!");
        }

        public static DataTable MySelection(String sqlText)
        {
            dt = new DataTable();
            dt.Clear();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlText, Conn);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("db.MySelection \r\n" + e.Message);
            }
            return dt;
        }

        public static void MyCommand(String sqlText)
        {
            try
            {
                cmd = new SQLiteCommand(sqlText, Conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("db.MyCommand \r\n" + e.Message);
            }
        }
    }
}
