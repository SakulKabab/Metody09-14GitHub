using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meotdy09_14GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double x1, x2, d;
            Metody.Diskriminant(a, b, c, out x1, out x2, out d);
            if (d < 0) MessageBox.Show("Rovnice nema reseni v R");
            else if (d > 0) MessageBox.Show("Koren x1 je: " + x1 + " a koren x2 je: " + x2);
            else MessageBox.Show("Rovnice ma jedno dvojnasobne reseni " + x1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox4.Text;
            int cifSoucet = 0, lichCifSoucet = 0, sudCifSoucet = 0;
            if (Metody.ObsahujeCislici(s1, out cifSoucet, out lichCifSoucet, out sudCifSoucet))
            {
                MessageBox.Show("Obsahuje číslici");
                MessageBox.Show("Ciferný součet je " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel je " + lichCifSoucet);
                MessageBox.Show("Ciferný součet sudých čísel je " + sudCifSoucet);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox5.Text;
            int pocetSlov = Metody.PocetSlov(ref s);
            MessageBox.Show("pocet slov je: " + pocetSlov + "\nOdstraněné číslice: " + s);
        }
    }
}
