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
    public partial class Managepatient : Form
    {
        patient p1;
        Connection con;
        
    
        public Managepatient()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            p1 = new patient();
            string a;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox8.Text != "")
            {
                if (radioButton1.Checked)
                {
                    a = "male";
                    p1.insert(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, (comboBox1.Text), textBox8.Text, a);
                }

                else if (radioButton2.Checked)
                {
                    a = "female";
                    p1.insert(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, (comboBox1.Text), textBox8.Text, a);

                }

                MessageBox.Show("Data Inserted");
            }

            else
            {
                MessageBox.Show("Error! Please Insert Complete Data");
            }

            Managepatient obj = new Managepatient();
            obj.Show();
            this.Hide();



        }

        private void button10_Click(object sender, EventArgs e)
        {
             p1 = new patient();
                DataTable tbl = new DataTable();
                tbl = p1.ShowTable("SELECT * FROM patient");
                dataGridView1.DataSource = tbl;
            }
           


        

        private void button3_Click(object sender, EventArgs e)
        {
            Managedoctor D = new Managedoctor();
            D.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Managenurse n = new Managenurse();
            n.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (comboBox.Text != "")
            {
                p1 = new patient();
                DataTable tbl = new DataTable();
                tbl = p1.ShowTable("SELECT * FROM patient WHERE p_ID = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = tbl;
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }


        }
            

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text != "" && textBox16.Text != "" && textBox14.Text != "" && textBox12.Text != "" && textBox10.Text != "" && textBox9.Text != "")
            {
                p1 = new patient();
                p1.update(Convert.ToInt32(comboBox6.Text), textBox16.Text, textBox14.Text, textBox12.Text, textBox10.Text, textBox9.Text);
                MessageBox.Show("Data Updated");

                textBox9.Clear();
                textBox10.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox16.Clear();

            }
            else
            {
                MessageBox.Show("Please Select An Id And Insert Data");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (comboBox3.Text != "")
            {
                p1 = new patient();
                p1.delete(Convert.ToInt32(comboBox3.Text));
                MessageBox.Show("Data Deleted");

              
               
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void Managepatient_Load(object sender, EventArgs e)
        {
            con = new Connection();
            string query = "SELECT p_ID from patient";
            OleDbCommand cmd = new OleDbCommand(query, con.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0].ToString());
                comboBox6.Items.Add(reader[0].ToString());
                comboBox3.Items.Add(reader[0].ToString());
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Managepatient p = new Managepatient();
            p.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
