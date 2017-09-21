using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace project
{
    class Connection
    {
        static string ibrar = @"provider=microsoft.ace.oledb.12.0;data source=E:\final\ibrar.accdb";
        public OleDbConnection Connect()
        {
            try
            {
                OleDbConnection a = new OleDbConnection(ibrar);
                a.Open();
                return a;

            }
            catch (Exception excep)
            {
                throw excep;
            }

        }
    }
}


      



   

