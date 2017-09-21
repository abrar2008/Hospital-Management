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
    public partial class Managebedallotment : Form
    {
        bedallotment bd;
      
        public Managebedallotment()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && radioButton1.Checked)
            {
                bd = new bedallotment();
                bd.insert(textBox2.Text, comboBox4.Text, radioButton1.Text, textBox4.Text, textBox5.Text, textBox1.Text);
                MessageBox.Show("Data Inserted");
            }
            else if (comboBox4.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && radioButton2.Checked)
            {
                bd.insert(textBox2.Text, comboBox4.Text, radioButton2.Text, textBox4.Text, textBox5.Text, textBox1.Text);
                MessageBox.Show("Data Inserted");

            }
            else
            {
                MessageBox.Show("Error! Insert Complete Data");
            }

            Managebedallotment obj = new Managebedallotment();
            obj.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (comboBox3.Text != "")
            {
                bd = new bedallotment();
                bd.delete(Convert.ToInt32(comboBox3.Text));
                MessageBox.Show("Data Deleted");

                string a = comboBox3.Text;
                bd.select(Convert.ToInt32(a));

            }
            else
            {
                MessageBox.Show("Please Select An Id");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Managebedallotment_Load(object sender, EventArgs e)
        {
            bd = new bedallotment();
            bd.bedload(comboBox4);
            bd.bedload(comboBox1, comboBox3);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

