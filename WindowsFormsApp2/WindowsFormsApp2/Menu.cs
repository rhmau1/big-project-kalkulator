using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {
        int num1;
        int num2;
        int hasil;
        public Menu()
        {
            InitializeComponent();
        }        

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "1" || textBoxOutput.Text=="2" || textBoxOutput.Text=="3" || textBoxOutput.Text=="4")
            {
                button11.Enabled = true;
            }            
        }

        private void textBoxAngka1_TextChanged(object sender, EventArgs e)
        {
            
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

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button18.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxAngka2.Text += button16.Text;
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

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "1")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 + num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
            if (textBoxOutput.Text == "2")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 - num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
            if (textBoxOutput.Text == "3")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 * num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
            if (textBoxOutput.Text == "4")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 / num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonEnter.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "1")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 + num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
            if (textBoxOutput.Text == "2")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 - num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
            if (textBoxOutput.Text == "3")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 * num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
            if (textBoxOutput.Text == "4")
            {
                num1 = int.Parse(textBoxAngka1.Text);
                num2 = int.Parse(textBoxAngka2.Text);

                hasil = num1 / num2;

                MessageBox.Show("Hasil perhitungan adalah: " + Convert.ToString(hasil));
            }
        }

        private void textBoxAngka2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAngka2 != null)
            {
                buttonHitung.Enabled = true;
                button10.Enabled = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxAngka1.Clear();
            textBoxOutput.Clear();
            textBoxAngka2.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
        }
    }
}
