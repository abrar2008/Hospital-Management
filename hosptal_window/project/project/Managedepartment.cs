using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Managedepartment : Form
    {
        department d1;
        public Managedepartment()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                d1.insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("Data Inserted");

            }

            else
            {
                MessageBox.Show("Error! Please Insert Complete Data");
            }

            Managedepartment d = new Managedepartment();
            d.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                d1 = new department();
                DataTable tbl = new DataTable();
                tbl = d1.ShowTable("SELECT * FROM department WHERE ID = '" + comboBox1.Text + "'");
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
            d1 = new department();
            DataTable tbl = new DataTable();
            tbl = d1.ShowTable("SELECT * FROM department");
            dataGridView1.DataSource = tbl;





        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox4.Text != "" && textBox3.Text != "")
            {
                d1.update(Convert.ToInt32(comboBox2.Text), textBox4.Text, textBox3.Text);
                MessageBox.Show("Data Updated");

                textBox3.Clear();
                textBox4.Clear();

                

                d1.select(comboBox1, comboBox2, comboBox3);
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
                d1.delete(Convert.ToInt32(comboBox3.Text));
                MessageBox.Show("Data Deleted");

                string a = comboBox3.Text;
                d1.select(Convert.ToInt32(a));
                
            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }
        }

        private void Managedepartment_Load(object sender, EventArgs e)
        {
            d1 =new department();
            d1.select(comboBox1, comboBox2, comboBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
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
