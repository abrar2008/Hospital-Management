using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project
{
    class Human
    {
        public virtual void insert(string name, string emailid, string address, string contactno, string gender)
        { }

        public virtual void insert(string name, string emailid, string address, string contactno, string age, string gender)
        { }

        public virtual void insert(string doctorname, string emailid, string address, string contactno, string qualification, string department, string gender)
        { }

        
        




        public virtual DataTable ShowTable(string query)
        {
          
           DataTable  tbl = new DataTable();
          
            return tbl;
        }

        public virtual DataTable ShowTable()
        {

            DataTable tbl = new DataTable();

            return tbl;
        }



        public virtual void update(int id, string name, string emailid, string address, string contactno)
        { }

        public virtual void update(int id, string name, string emailid, string address, string contactno, string age)
        { }

        public virtual void update(int id, string doctorname, string emailid, string address, string contactno, string qualification, string department)
        { }

        public virtual void delete(int id)
        { }
       


    }
}
