using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace project
{
    class Nurse :Human
    {
       
        Connection b;
        DataTable tbl;



        public override void insert(string name, string emailid, string address, string contactno, string age, string gender)
        {
            b = new Connection();
            string query = "insert into nurse (Name,EmailId,Address,ContactNo,Age,Gender) values ('" + name + "','" + emailid + "','" + address + "','" + contactno + "','" + age + "','" + gender + "')";
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }
       
       

        public override void update(int id, string name, string emailid, string address, string contactno, string age)
        {
            b = new Connection();

            string query = "update nurse set Name='" + name + "',EmailID='" + emailid + "',Address='" + address + "',ContactNo='" + contactno + "' ,Age='" + age + "'where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }
        public override void delete(int id)
        {
            b = new Connection();
            string query = "delete * from nurse where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }

        public override DataTable ShowTable(string query)
        {
            b = new Connection();
            tbl = new DataTable();
            OleDbDataAdapter dta = new OleDbDataAdapter(query, b.Connect());
            dta.Fill(tbl);
            return tbl;
        }




    }
}
