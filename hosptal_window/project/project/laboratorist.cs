using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace project
{
    class laboratorist:Human
    {
        
        Connection b;
        public override void insert(string name, string emailid, string address, string contactno, string gender)
        {
            b = new Connection();
            string query = "insert into laboratorist (Name,EmailId,Address,ContactNo,Gender) values ('" + name + "','" + emailid + "','" + address + "','" + contactno + "','" + gender + "')";
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }
      
        public override void update(int id, string name, string emailid, string address, string contactno)
        {
            b = new Connection();
            string query = "update laboratorist set Name='" + name + "',EmailID='" + emailid + "',Address='" + address + "',ContactNo='" + contactno + "'where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }
        public override void delete(int id)
        {
            b = new Connection();
            string query = "delete * from laboratorist where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }
        public override DataTable ShowTable(string query)
        {
            b = new Connection();
            DataTable tbl = new DataTable();
            OleDbDataAdapter dta = new OleDbDataAdapter(query, b.Connect());
            dta.Fill(tbl);
            return tbl;
        }


    }
}
