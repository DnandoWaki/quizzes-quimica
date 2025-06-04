using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joguinho.Resources
{
    public partial class Inicio : Form
    {
        Variaveis V = new Variaveis();
        public Inicio()
        {
            InitializeComponent();
        }

        private void Jogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questao1 abre = new Questao1();
            abre.ShowDialog();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Global.Acerto = Global.Acerto + 10;
            this.Hide();
            Final abre = new Final();
            abre.ShowDialog();
        }
    }
}
