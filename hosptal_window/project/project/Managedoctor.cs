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
    public partial class Managedoctor : Form
    {
        Doctor dc;
        Connection con;
        
        
        public Managedoctor()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dc = new Doctor();
            string a;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                if (radioButton1.Checked)
                {
                    a = "male";
                    dc.insert(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, a);
                }

                else if (radioButton2.Checked)
                {
                    a = "female";
                    dc.insert(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, a);
                }

                MessageBox.Show("Data Inserted");
            }

            else
            {
                MessageBox.Show("Error! Please Insert Complete Data");
            }

            Managedoctor obj = new Managedoctor();
            obj.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
          dc = new Doctor();
        

                 if (comboBox1.Text != "")
            {
                dataGridView1.Show();
                dataGridView1.DataSource = dc.select(Convert.ToInt32(comboBox1.Text)).Tables[0];
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }
            
         

        

        private void button12_Click(object sender, EventArgs e)
        {
            

          
                dc = new Doctor();
                DataTable tbl = new DataTable();
                tbl = dc.ShowTable("SELECT * FROM doctor");
                dataGridView1.DataSource = tbl;

            
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            dc = new Doctor();
            DataTable tbl = new DataTable();
       
            dataGridView1.DataSource = tbl;

            if (comboBox3.Text != "" && textBox17.Text != "" && textBox15.Text != "" && textBox14.Text != "" && textBox13.Text != "" && textBox12.Text != "" && textBox11.Text != "")
            {
                dc.update(Convert.ToInt32(comboBox3.Text), textBox17.Text, textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text);
                MessageBox.Show("Data Updated");

                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();


            }
            else
            {
                MessageBox.Show("Please Select An Id And Insert Data");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
          

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                
              
                
                     
                dc = new Doctor();
                dc.delete(Convert.ToInt32(comboBox2.Text));
                MessageBox.Show("Data Deleted");

               
                               
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
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

        private void Managedoctor_Load(object sender, EventArgs e)
        {
           con = new Connection();
            string query = "SELECT D_ID from doctor ";
            OleDbCommand cmd = new OleDbCommand(query, con.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox2.Items.Add(reader[0].ToString());
                comboBox3.Items.Add(reader[0].ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Managebedallotment b = new Managebedallotment();
            b.Show();
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
    }
    }

