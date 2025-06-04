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
    public partial class Questao4 : Form
    {
        Variaveis V = new Variaveis();
        public Questao4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao5 abre = new Questao5();
            abre.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.Acerto = Global.Acerto + 1;
            this.Hide();
            Questao5 abre = new Questao5();
            abre.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao5 abre = new Questao5();
            abre.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao5 abre = new Questao5();
            abre.ShowDialog();

        }
    }
}
