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
    public partial class Questao5 : Form
    {
        Variaveis V = new Variaveis();
        public Questao5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower().Trim() == "combustão")
            {
                Global.Acerto = Global.Acerto + 1;
                this.Hide();
                Questao6 abre = new Questao6();
                abre.ShowDialog();
            }
            else
            {
                this.Hide();
                Questao6 abre = new Questao6();
                abre.ShowDialog();
            }
        }
    }
}
