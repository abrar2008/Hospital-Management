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
    public partial class Form1 : Form
    {
        Login a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Login(textBox1.Text, textBox2.Text);
            bool check = a.login();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (check == true)
                {
                    Managedoctor d = new Managedoctor();
                    d.Show();
                    this.Hide();
                    




                  
                   
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Specify User ID or Password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            A.Show();
            this.Hide();
        }
    }
}
