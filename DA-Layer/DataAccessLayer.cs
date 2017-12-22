using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DA_Layer;

namespace DA_Layer
{
    public class DataAccessLayer
    {
        SqlConnection CON;
        SqlCommand CMD;
        SqlDataAdapter DA;
        DataTable DT;
        public DataAccessLayer()
        {
            CON = new SqlConnection();
            CMD = new SqlCommand();
            DA = new SqlDataAdapter();
            CMD.Connection = CON;
            DA.SelectCommand = CMD;
        }
        public void Connect()
        {
            CON.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Police.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {
                CON.Open();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        public void Disconnect()
        {
            CON.Close();
        }
        public DataTable Select(string Query)
        {
            CMD.CommandText = Query;
            DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }
        public void DoCommand(string Query)
        {
            CMD.CommandText = Query;
            CMD.ExecuteNonQuery();
        }
    }
}
