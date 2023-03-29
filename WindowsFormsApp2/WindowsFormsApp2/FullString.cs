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
    public partial class FullString : Form
    {
        private string currentCalculation = "";
        public FullString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.
                ToString().Replace(" Dikali", "*").
                ToString().Replace(" Dibagi", "/").
                ToString().Replace(" Ditambah", "+").
                ToString().Replace(" Dikurang", "-").
                ToString().Replace(" Satu", "1").
                ToString().Replace(" Dua", "2").
                ToString().Replace(" Tiga", "3").
                ToString().Replace(" Empat", "4").
                ToString().Replace(" Lima", "5").
                ToString().Replace(" Enam", "6").
                ToString().Replace(" Tujuh", "7").
                ToString().Replace(" Delapan", "8").
                ToString().Replace(" Sembilan", "9").
                ToString().Replace(" Nol", "0");

            try
            {
                textBoxOutput.Text = new DataTable().Compute(formattedCalculation, null).
                    ToString().Replace("1", " Satu").
                    ToString().Replace("2", " Dua").
                    ToString().Replace("3", " Tiga").
                    ToString().Replace("4", " Empat").
                    ToString().Replace("5", " Lima").
                    ToString().Replace("6", " Enam").
                    ToString().Replace("7", " Tujuh").
                    ToString().Replace("8", " Delapan").
                    ToString().Replace("9", " Sembilan");
                currentCalculation = textBoxOutput.Text;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                currentCalculation = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            currentCalculation = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
