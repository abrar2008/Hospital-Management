using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;



namespace project
{
    class Login
    {
        
        Connection p;
        string username;
        string password;

        public Login()
        {

        }
        public Login( string _username , string _password)
        {
            username = _username;
            password = _password;

            
        }

        public bool login()
        {
            p = new Connection();
            bool _check;

            string quries = "SELECT * FROM login  WHERE user_name = '" + username + "' AND user_pass = '" + password + "'";
            OleDbCommand cmd = new OleDbCommand(quries, p.Connect());
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                _check = true;
            }
            else
            {
                _check = false;
            }
            return _check;

        }


        







    }
}
