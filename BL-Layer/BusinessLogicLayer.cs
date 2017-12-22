using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DA_Layer;

namespace BL_Layer
{
    public class BusinessLogicLayer : DataAccessLayer
    {
        public DataTable DT = new DataTable();
        public int ID;
        public DataTable Login(bool Permission, string Username, string Password)
        {
            base.Connect();
            string Query = "SELECT * FROM TblLogin WHERE Permission='" + Permission + "' AND Username='" + Username + "' AND Password='" + Password + "'";
            DT = base.Select(Query);
            base.Disconnect();
            return DT;
        }
        //    public DataTable View()
        //    {
        //        base.Connect();
        //        string Query = "SELECT * FROM Person_Information";
        //        DT = base.Select(Query);
        //        base.Disconnect();
        //        return DT;
        //    }
        //    public DataTable SelectOne(int ID)
        //    {
        //        base.Connect();
        //        string Query = "SELECT * FROM Person_Information WHERE ID={0}";
        //        Query = string.Format(Query, ID);
        //        DT = base.Select(Query);
        //        base.Disconnect();
        //        return DT;
        //    }
        //    public void Insert (string Fname,string Lname,string NationalCode,string CertificateCode)
        //    {
        //        base.Connect();
        //        string Query = "INSERT INTO Person_information (Fname,Lname,NationalCode,CertificateCode) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')";
        //        Query = string.Format(Query, Fname, Lname, NationalCode, CertificateCode);
        //        base.DoCommand(Query);
        //        base.Disconnect();
        //    }
        //    public void Update(string Fname, string Lname, string NationalCode, string CertificateCode)
        //    {
        //        base.Connect();
        //        string Query = "UPDATE Person_information SET Fname=N'{0}',Lname=N'{1}',NationalCode=N'{2}',CertificateCode=N'{3}' WHERE ID={4}";
        //        Query = string.Format(Query, Fname, Lname, NationalCode, CertificateCode,ID);
        //        base.DoCommand(Query);
        //        base.Disconnect();
        //    }
        //    public void Delete()
        //    {
        //        base.Connect();
        //        string Query = "DELETE FROM Person_information WHERE ID={0}";
        //        Query = string.Format(Query, ID);
        //        base.DoCommand(Query);
        //        base.Disconnect();
        //    }
        //}
    }
}