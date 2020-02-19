using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Investment.Models
{
    public class Conexao_sql_server
    {
        private SqlConnection con;
        private SqlDataAdapter adpt;
        public DataSet ds = new DataSet();
        private String strCon = "Data Source=DESKTOP-TASKLAC;Initial Catalog=Investment;User ID=felipe;Password=vasco1898"; 
    
        public void Conectar()
        {
            con = new SqlConnection(strCon);
            con.Open();
            MessageBox.Show("Conexão feita!");

        }
    }
}