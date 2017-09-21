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
    class bedallotment
    {

        Connection b;
        public void insert(string bedno, string name, string a, string admittime, string dischargetime, string bill)
        {
            b = new Connection();

            if (a == "Normal")
            {



                string query = "insert into bedallotment (BedNo,Patient_Id_Or_Name,BedType,AdmitTime,DischargeTime,Bill) values ('" + bedno + "','" + name + "','" + a + "','" + admittime + "','" + dischargetime + "','" + bill + "')";
                OleDbCommand com = new OleDbCommand(query, b.Connect());
                com.ExecuteNonQuery();
            }
            else if (a == "Special")
            {
                b = new Connection();
                string query = "insert into bedallotment (BedNo,Patient_Id_Or_Name,BedType,AdmitTime,DischargeTime,Bill) values ('" + bedno + "','" + name + "','" + a + "','" + admittime + "','" + dischargetime + "','" + bill + "')";
                OleDbCommand com = new OleDbCommand(query, b.Connect());
                com.ExecuteNonQuery();
            }
        }


        public DataSet select(int id)
        {
            b = new Connection();
            DataSet dta = new DataSet();
            string query = "select * from bedallotment where ID=" + id;

            OleDbDataAdapter adp = new OleDbDataAdapter(query, b.Connect());
            adp.Fill(dta);
            return dta;
        }
        public DataSet showdat(string query)
        {
            b = new Connection();
            DataSet dta = new DataSet();
            

            OleDbDataAdapter adp = new OleDbDataAdapter(query, b.Connect());
            adp.Fill(dta);
            return dta;
        }
    
       

        
        public void delete(int id)
        {
            b = new Connection();
            string query = "delete * from bedallotment where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, b.Connect());
            com.ExecuteNonQuery();
        }



        public void bedload(ComboBox c1)
        {
            b = new Connection();

            string query = "select * from bedallotment";

            OleDbCommand cmd = new OleDbCommand(query, b.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                c1.Items.Add(reader[0].ToString() + "  :   " + reader[1].ToString());
            }
        }


        public void bedload(ComboBox c1, ComboBox c2)
        {
            b = new Connection();

            string query = "select * from bedallotment";

            OleDbCommand cmd = new OleDbCommand(query, b.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                c1.Items.Add(reader[0].ToString());
                c2.Items.Add(reader[0].ToString());

            }

        }
    }

}

