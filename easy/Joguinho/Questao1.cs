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
    public partial class Questao1 : Form
    {
        Variaveis V = new Variaveis();
       // public int contaacertos;

        public Questao1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.Acerto = Global.Acerto + 1;
            this.Hide();
            Questao2 abre = new Questao2();
            abre.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao2 abre = new Questao2();
            abre.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao2 abre = new Questao2();
            abre.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao2 abre = new Questao2();
            abre.ShowDialog();
        }
    }
}
