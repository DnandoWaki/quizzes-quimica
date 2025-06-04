using Joguinho.Resources;
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
    public partial class Final : Form
    { 
        Variaveis V = new Variaveis();
        public Final()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            V.calcular();
            label5.Text = (Convert.ToString(Global.Acerto));
            label6.Text = (Convert.ToString(V.Erros));
            if (Global.Acerto == 10 && V.Erros == 0 && Global.Tentativas == 0)
            {
                Label[] labels = { label1 };
                ativar(labels, button2);
            }
            else if (Global.Acerto == 10 && V.Erros == 0 && Global.Tentativas != 0)
            {
                Label[] labels = { label4, label9, label10 };
                ativar(labels, button2);
                label10.Text = (Convert.ToString(Global.Tentativas));
            }
            else if(Global.Acerto < 10 && Global.Acerto >= 5)
            {
                Label[] labels = { label3, label9, label10 };
                ativar(labels, button3);
                label10.Text = (Convert.ToString(Global.Tentativas));
            }
            else if (Global.Acerto <= 4 && Global.Acerto >= 0)
            {
                Label[] labels = {label2, label9, label10};
                ativar(labels, button3);
                label10.Text = (Convert.ToString(Global.Tentativas));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.Acerto = 0;
            Global.Tentativas = 0;
            this.Hide();
            Inicio abre = new Inicio();
            abre.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.Tentativas = Global.Tentativas + 1;
            Global.Acerto = 0;
            this.Hide();
            Inicio abre = new Inicio();
            abre.ShowDialog();
        }

        private void ativar(Label[] nomes, Button btnnome)
        {
            foreach (Label nome in nomes)
            {
                nome.Enabled = true;
                nome.Visible = true;
            }

            btnnome.Enabled = true;
            btnnome.Visible = true;

        }
    }
}
