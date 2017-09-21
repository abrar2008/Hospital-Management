using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace project
{
    class patient : Human
    {
       
        Connection b;
        public override void insert(string name, string emailid, string address, string contactno, string bloodgroup, string age, string gender)
        {
            b = new Connection();
            string query = "insert into patient (Name,EmailId,Address,ContactNo,BloodGroup,Age,Gender) values ('" + name + "','" + emailid + "','" + address + "','" + contactno + "','" + bloodgroup + "','" + age + "','" + gender + "')";
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }
        
      
        public override void update(int id, string name, string emailid, string address, string contactno, string age)
        {
            b = new Connection();
            string query = "update patient set Name='" + name + "',EmailID='" + emailid + "',Address='" + address + "',ContactNo='" + contactno + "' ,Age='" + age + "'where p_ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();

        }

        public override void delete(int id)
        {
            b = new Connection();
            string query = "delete * from patient where p_ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();

        }
        public override DataTable ShowTable(string query)
        {
            b = new Connection();
          DataTable  tbl = new DataTable();
            OleDbDataAdapter dta = new OleDbDataAdapter(query, b.Connect());
            dta.Fill(tbl);
            return tbl;
        }
        public string[] patientload()
        {
            string[] array = new string[8];

            array[0] = "A+";
            array[1] = "A-";
            array[2] = "B+";
            array[3] = "B-";
            array[4] = "AB+";
            array[5] = "AB-";
            array[6] = "O+";
            array[7] = "O-";

            return array;

        }




    }
}
