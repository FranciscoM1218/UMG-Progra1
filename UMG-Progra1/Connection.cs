using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UMG_Progra1
{
    class Connection
    {
        private static SqlConnection connection = new SqlConnection(Properties.Settings.Default.conexion);

        public static SqlCommand command (String query)
        {
            return new SqlCommand(query, connection);
        }
        public static SqlDataReader exec (String query)
        {
            SqlCommand cmd = command(query);
            connection.Close();
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataAdapter getAdapter (String tableName, String where)

        {
            SqlCommand cmd = command(String.Format("SELECT * FROM [dbo].[{0}] {1}",  tableName, where));
            return new SqlDataAdapter(cmd);
        }

        public static SqlDataAdapter getAdapter(String tableName)
        {
            return getAdapter(tableName,"");
        }
        
        public static void deleteRow (String tableName, int id)
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = command(String.Format("DELETE FROM [dbo].[{0}] WHERE id_user = @id", tableName));
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
