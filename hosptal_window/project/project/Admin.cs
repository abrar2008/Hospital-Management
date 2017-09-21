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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void button12_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();

           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pat a = new pat();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pat a = new pat();
            a.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Managelaboratorist la = new Managelaboratorist();
            la.Show();
            this.Hide();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Managebedallotment bld = new Managebedallotment();
            bld.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            

        }

        private void button18_Click(object sender, EventArgs e)
        {

            MED m = new MED();
            m.Show();
            this.Hide();
          
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Managedepartment d = new Managedepartment();
            d.Show();
            this.Hide();
                 
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Managelaboratorist l = new Managelaboratorist();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Managedepartment D = new Managedepartment();
            D.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
