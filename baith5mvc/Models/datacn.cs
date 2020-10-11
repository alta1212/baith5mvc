using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace baith5mvc.Models
{
    public class datacn
    {
        SqlDataAdapter da;
        SqlCommand cmt;
        DataTable dt;
        SqlConnection cn;
        //lấy về chuỗi kết nối bên web.config
        string connect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        void dataconect()
        {
            cn = new SqlConnection(connect);
        }
        public DataTable laydulieu(string query)
        {
            dataconect();
            da = new SqlDataAdapter(query, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }    
    }
}