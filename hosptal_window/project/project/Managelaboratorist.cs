using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Managelaboratorist : Form
    {
        Connection con;
        laboratorist L1;
       

        public Managelaboratorist()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            L1 = new laboratorist();
            string a;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (radioButton1.Checked)
                {
                    a = "male";
                    L1.insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, a);
                }

                else if (radioButton2.Checked)
                {
                    a = "female";
                    L1.insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, a);

                }

                MessageBox.Show("Data Inserted");
            }

            else
            {
                MessageBox.Show("Error! Please Insert Complete Data");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text != "")
            {
                L1 = new laboratorist();
                DataTable tbl = new DataTable();
                tbl = L1.ShowTable("SELECT * FROM laboratorist WHERE ID = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = tbl;
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            L1 = new laboratorist();
            DataTable tbl = new DataTable();
            tbl = L1.ShowTable("SELECT * FROM laboratorist");
            dataGridView1.DataSource = tbl;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox8.Text != "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                L1.update(Convert.ToInt32(comboBox2.Text), textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
                MessageBox.Show("Data Updated");

                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();


            }
            else
            {
                MessageBox.Show("Please Select An Id And Insert Data");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                L1 = new laboratorist();
                L1.delete(Convert.ToInt32(comboBox3.Text));
                MessageBox.Show("Data Deleted");

               
               
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Managelaboratorist_Load(object sender, EventArgs e)
        {
            {
                con = new Connection();
                string query = "SELECT ID from  laboratorist";
                OleDbCommand cmd = new OleDbCommand(query, con.Connect());
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                    comboBox2.Items.Add(reader[0].ToString());
                    comboBox3.Items.Add(reader[0].ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a= new Admin();
            a.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Managedepartment d = new Managedepartment();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Managedoctor d = new Managedoctor();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Managepatient p = new Managepatient();
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Managenurse n = new Managenurse();
            n.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Managelaboratorist l = new Managelaboratorist();
            l.Show();
            this.Hide();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
