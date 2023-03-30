using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu formBaru = new Menu();
            formBaru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StrSimbol formBaru = new StrSimbol();
            formBaru.Show();           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simbol formBaru = new Simbol();
            formBaru.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FullString formBaru = new FullString();
            formBaru.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChallengeVer1 formBaru = new ChallengeVer1();
            formBaru.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChallengeVer2 formBaru = new ChallengeVer2();
            formBaru.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Profil formBaru = new Profil();
            formBaru.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
