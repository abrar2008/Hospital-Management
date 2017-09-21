using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace project
{
    class Doctor:Human
    {
        Connection a;
        DataTable tbl;


        public override void insert(string doctorname, string emailid, string address, string contactno, string qualification, string department, string gender)
        {
            a = new Connection();
            string query = "insert into doctor (DoctorName,EmailId,Address,ContactNo,Qualification,Department,gender) values ('" + doctorname + "','" + emailid + "','" + address + "','" + contactno + "','" + qualification + "','" + department + "','" + gender + "')";
            OleDbCommand cmd = new OleDbCommand(query, a.Connect());
            cmd.ExecuteNonQuery();

        }
      
        public override void update(int id, string doctorname, string emailid, string address, string contactno, string qualification, string department)
        {
            a = new Connection();
            string query = "update doctor set DoctorName='" + doctorname + "',EmailID='" + emailid + "',Address='" + address + "',ContactNo='" + contactno + "',Qualification='" + qualification + "',Department='" + department + "'where  d_ID=" + id;
            OleDbCommand cmd = new OleDbCommand(query, a.Connect());
            cmd.ExecuteNonQuery();
        }

        public override void delete(int id)
        {
            a = new Connection();
            string query = "delete * from doctor where d_ID=" + id;
            OleDbCommand cmd = new OleDbCommand(query, a.Connect());
            cmd.ExecuteNonQuery();

        }
        public override DataTable ShowTable(string query)
        {
            a = new Connection();
                   
            tbl = new DataTable();
            OleDbDataAdapter dta = new OleDbDataAdapter(query, a.Connect());
            
            dta.Fill(tbl);
            return tbl;
        }

        public DataSet select(int id)
        {
            a = new Connection();
            DataSet asd = new DataSet();
            string query = "select * from bedallotment where ID=" + id;

            OleDbDataAdapter adp = new OleDbDataAdapter(query, a.Connect());
            adp.Fill(asd);
            return asd;
        }





    }
}
