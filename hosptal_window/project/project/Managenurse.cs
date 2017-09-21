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
    public partial class Managenurse : Form
    {
        Nurse n1;
        Connection con;
 

        
       
        public Managenurse()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            n1 = new Nurse();
            string a;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox8.Text != "")
            {
                if (radioButton1.Checked)
                {
                    a = "male";
                    n1.insert(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox8.Text, a);
                }

                else if (radioButton2.Checked)
                {
                    a = "female";
                    n1.insert(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox8.Text, a);

                }

                MessageBox.Show("Data Inserted");
            }

            else
            {
                MessageBox.Show("Error! Please Insert Complete Data");
            }

            Managenurse obj = new Managenurse();
            obj.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n1 = new Nurse();
            if (comboBox1.Text != "")
            {
                n1 = new Nurse();

                DataTable tbl = new DataTable();
                tbl = n1.ShowTable("SELECT * FROM nurse WHERE n_ID= '" + comboBox1.Text + "'");
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
            n1 = new Nurse();
               
            DataTable tbl = new DataTable();
            tbl = n1.ShowTable("SELECT * FROM nurse");
            dataGridView1.DataSource = tbl;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
            
        }

        private void Managenurse_Load(object sender, EventArgs e)
        {
            con = new Connection();
            string query = "SELECT  ID from nurse";
            OleDbCommand cmd = new OleDbCommand(query, con.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox2.Items.Add(reader[0].ToString());
                comboBox3.Items.Add(reader[0].ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text != "" && textBox14.Text != "" && textBox12.Text != "" && textBox11.Text != "" && textBox10.Text != "" && textBox6.Text != "")
            {
                n1.update(Convert.ToInt32(comboBox2.Text), textBox14.Text, textBox12.Text, textBox11.Text, textBox10.Text, textBox6.Text);
                MessageBox.Show("Data Updated");

                textBox6.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();

            }
            else
            {
                MessageBox.Show("Please Select An Id And Insert Data");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                n1 = new Nurse();
                n1.delete(Convert.ToInt32(comboBox3.Text));
                MessageBox.Show("Data Deleted");

                
               
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Managedepartment d = new Managedepartment();
            d.Show();
            this.Hide();
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

