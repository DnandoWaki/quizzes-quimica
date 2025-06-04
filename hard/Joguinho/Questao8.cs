using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joguinho
{
    public partial class Questao8 : Form
    {
        Variaveis V = new Variaveis();
        public Questao8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower().Trim() == "ácido perbrômico" && textBox2.Text == "ácido hipocloroso" && textBox3.Text == "ácido fluoroso" && textBox4.Text == "ácido persulfúrico")
            {
                Global.Acerto = Global.Acerto + 1;
                this.Hide();
                Questao9 abre = new Questao9();
                abre.ShowDialog();
            }
            else
            {
                this.Hide();
                Questao9 abre = new Questao9();
                abre.ShowDialog();
            }
        }
    }
}
