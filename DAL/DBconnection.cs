using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
namespace DAL
{
    public class DBconnection
    {

        public SqlCeConnection cn = new SqlCeConnection(@"Data Source=C:\Users\WIKI\source\repos\tapp\DB.sdf;Password=amina");
        public SqlCeConnection getCon()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }
        public int ExeNonQuery(SqlCeCommand cmd)
        {
            cmd.Connection = getCon();
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            cn.Close();
            return rows;
        }
        public DataTable ExeReader(SqlCeCommand cmd)
        {
            cmd.Connection = getCon();
            SqlCeDataReader sr;
            DataTable dt = new DataTable();
            sr = cmd.ExecuteReader();
            dt.Load(sr);
            cn.Close();
            return dt;
        }
        public SqlCeDataReader Reader(SqlCeCommand cmd)
        {
            cmd.Connection = getCon();
            SqlCeDataReader sr;

            sr = cmd.ExecuteReader();

            cn.Close();
            return sr;
        }
    }
}
