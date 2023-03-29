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
    public partial class Simbol : Form
    {
        int num1, num2, hasil;       
        public Simbol()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAngka1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAngka1 != null)
            {
                buttonEnter.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Text += button0.Text;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
        }

        private void Simbol_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button21.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button19.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button18.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button15.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button12.Text;
        }

        private void textBoxAngka2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAngka2 != null)
            {
                button10.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOutput != null)
            {
                buttonHitung.Enabled = true;
            }
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "+")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);
                hasil = num1 + num2;

                MessageBox.Show("Hasil perhitungan adalah:" + hasil);
            }
            if(textBoxOutput.Text == "-")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);
                hasil = num1 - num2;

                MessageBox.Show("Hasil perhitungan adalah:" + hasil);
            }
            if(textBoxOutput.Text== "*")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);
                hasil = num1 * num2;

                MessageBox.Show("Hasil perhitungan adalah:" + hasil);
            }
            if(textBoxOutput.Text == ":")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);
                hasil = num1 / num2;

                MessageBox.Show("Hasil perhitungan adalah:" + hasil);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += button24.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += button23.Text;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Clear();
            textBoxAngka2.Clear();
            textBoxOutput.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += button11.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += button22.Text;
        }
    }
}
