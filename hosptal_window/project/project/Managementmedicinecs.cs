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
    public partial class Managementmedicinecs : Form
    {
        Connection con;
        medicine m;
        public Managementmedicinecs()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            m = new medicine();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                m.insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                MessageBox.Show("Data Inserted");
            }

            else
            {
                MessageBox.Show("Error! Please Insert Complete Data");
            }

            Managementmedicinecs m1 = new Managementmedicinecs();
            m1.Show();
            this.Hide();
        }
    

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox8.Text != "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                m = new medicine();
                m.update(Convert.ToInt32(comboBox2.Text), textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
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

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                m = new medicine();
                m.delete(Convert.ToInt32(comboBox3.Text));
                MessageBox.Show("Data Deleted");

                string a = comboBox3.Text;
                m.select(Convert.ToInt32(a));
                
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void Managementmedicinecs_Load(object sender, EventArgs e)
        {
            con = new Connection();
            string query = "SELECT ID from medicine ";
            OleDbCommand cmd = new OleDbCommand(query, con.Connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox2.Items.Add(reader[0].ToString());
                comboBox3.Items.Add(reader[0].ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                m = new medicine();
                dataGridView1.Show();
                dataGridView1.DataSource = m.select(Convert.ToInt32(comboBox1.Text)).Tables[0];
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            m = new medicine();
            dataGridView1.Show();
            dataGridView1.DataSource = m.select().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Managebedallotment b = new Managebedallotment();
            b.Show();
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

