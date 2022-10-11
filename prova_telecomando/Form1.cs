using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_telecomando
{
    public partial class Form1 : Form
    {
        telecomando uno = new telecomando();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = "1";
            canale(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = "2";
            canale(num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = "3";
            canale(num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = "4";
            canale(num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = "5";
            canale(num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num = "6";
            canale(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num = "7";
            canale(num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string num = "8";
            canale(num);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string num = "9";
            canale(num);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string num = "0";
            canale(num);
        }
        public void canale(string num)
        {
            if (label1.Text == "0")
            {
                label1.Text = num;
            }
            else
            {
                int a = Convert.ToInt32(label1.Text) * 10;
                a = a + int.Parse(num);
                label1.Text = Convert.ToString(a);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int canale_definito=int.Parse(label1.Text);
            label1.Text = "0";
            if (canale_definito < 1000)
            {
                uno.setcanale(canale_definito);
            }
            else
            {
                MessageBox.Show("Il canale inserito supera il limite di 999, si prega di scegliere un canale disponibile");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string stato;
            if (uno.get_stato() == true) 
            {
                stato = "on";
            }
            else
            {
                stato = "off";
            }
            string[] array=uno.get_specifiche();
            string produttore = array[0], modello = array[1], modalita = array[2];

            textBox1.Text = "il produttore del telecomando è: " + produttore + "il modello del telecomando è: " + modello + "la modalita del telecomando è: " + modalita + "il canale su cui si è in questo momento è: " + Convert.ToString(uno.getcanale()) + '\n' + "lo stato della televisione è: " + stato + '\n' + "il volume in questo momento impostato è: " + Convert.ToString(uno.get_volume());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            uno.cambio_stato();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            uno.volume_giu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            uno.volume_su();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
            {
                uno.set_specifiche(textBox2.Text, textBox3.Text, textBox4.Text);
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
            }
            else
            {
                MessageBox.Show("uno o più campi non sono stati completati, si prega di riempirli prima di procedere");
            }
        }
    }
}
