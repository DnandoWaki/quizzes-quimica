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
    public partial class Questao3 : Form
    {
        Variaveis V = new Variaveis();
        public Questao3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower().Trim() == "pressão atmosférica")
            {
                Global.Acerto = Global.Acerto + 1;
                this.Hide();
                Questao4 abre = new Questao4();
                abre.ShowDialog();
            }
            else
            {
                this.Hide();
                Questao4 abre = new Questao4();
                abre.ShowDialog();
            }
        }
    }
}
