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
    class medicine
    {
        
        Connection a;

        public void insert(string medicinename, string description, string price, string companyname)
        {
            a = new Connection();
            string query = "insert into medicine (MedicineName,Description,Price,CompanyName) values ('" + medicinename + "','" + description + "','" + price + "','" + companyname + "')";
            OleDbCommand com = new OleDbCommand(query, a.Connect());
            com.ExecuteNonQuery();
        }
        public DataSet select(int id)
        {
            a = new Connection();
            DataSet ada = new DataSet();
            string query = "select * from medicine where ID=" + id;

            OleDbDataAdapter adp = new OleDbDataAdapter(query, a.Connect());
            adp.Fill(ada);
            return ada;
        }



        public DataSet select()
        {
            a = new Connection();
            DataSet ahsan = new DataSet();
            string query = "select * from medicine";

            OleDbDataAdapter adp = new OleDbDataAdapter(query, a.Connect());
            adp.Fill(ahsan);
            return ahsan;
        
        
        }
          public void update(int id, string medicinename, string description, string price, string companyname)
        {
            a = new Connection();
            string query = "update medicine set MedicineName='" + medicinename + "',Description='" + description + "',Price='" + price + "',CompanyName='" + companyname + "'where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, a.Connect());
            com.ExecuteNonQuery();
        }

        public void delete(int id)
        {
            a = new Connection();
            string query = "delete * from medicine where ID=" + id;
            OleDbCommand com = new OleDbCommand(query, a.Connect());
            com.ExecuteNonQuery();
        }

        




    }


    }


