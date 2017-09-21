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
    class department
    {
        Connection a;

        public void insert(string name, string description)
        {
            a = new Connection();
            string query = "insert into department (Name,Description) values ('" + name + "','" + description + "')";
            OleDbCommand com = new OleDbCommand(query, a.Connect());
            com.ExecuteNonQuery();
        }

        public DataSet select(int id)
        {
            a = new Connection();
            DataSet da = new DataSet();
            string query = "select * from department where ID=" + id;

            OleDbDataAdapter adp = new OleDbDataAdapter(query, a.Connect());
            adp.Fill(da);
            return da;
        }
        public DataTable ShowTable(string query)
        {
            a = new Connection();
             DataTable tbl = new DataTable();
            OleDbDataAdapter adap = new OleDbDataAdapter(query, a.Connect());
            adap.Fill(tbl);
            return tbl;
        }


        public void update(int id, string name, string description)
        {
            a = new Connection();
            string query = "update department set Name='" + name + "',Description='" + description + "'where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, a.Connect());
            com.ExecuteNonQuery();
        }

        public void delete(int id)
        {
            a = new Connection();
                 
            string query = "delete * from department where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, a.Connect());
            com.ExecuteNonQuery();
        }

        public void select(ComboBox c1, ComboBox c2, ComboBox c3)
        {
            a = new Connection();
            OleDbConnection b = new OleDbConnection();

            string query = "select * from department";

            OleDbCommand cmd = new OleDbCommand(query, a.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                c1.Items.Add(reader[0].ToString());
                c2.Items.Add(reader[0].ToString());
                c3.Items.Add(reader[0].ToString());
            }
        }




    }



}
