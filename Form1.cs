using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaAV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCargoParaVoto_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 1;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 2;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 3;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 4;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 5;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 6;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 7;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 8;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 9;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text.Length <= 4)
            {
                txtVoto.Text += 0;
            }
            else
            {
                txtVoto.Text = txtVoto.Text;
            }
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtVoto.Text = "BRANCO";
        }

        String votoDepFederal = "";
        String votoDepEstOuDist = "";
        String votoSenador = "";
        String votoGovernador = "";
        String votoPresidente = "";
        private void btnEnviar_Click(object sender, EventArgs e)
        {

            if(txtVoto.Text == "")
            {
                MessageBox.Show("Antes de confirmar o seu voto insira o numero do seu candidato," +
                    " caso opite por anulá-lo aperte o botão BRANCO.",
                    "Verifique o seu voto",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (votoDepFederal == "")
                {
                    votoDepFederal = txtVoto.Text;
                    txtVoto.Text = "";
                    lblCargoParaVoto.Text = "Deputado Estadual/Distrial";
                }
                else if (votoDepEstOuDist == "")
                {
                    votoDepEstOuDist = txtVoto.Text;
                    txtVoto.Text = "";
                    lblCargoParaVoto.Text = "Senador";
                }
                else if (votoSenador == "")
                {
                    votoSenador = txtVoto.Text;
                    txtVoto.Text = "";
                    lblCargoParaVoto.Text = "Governador";
                }
                else if(votoGovernador == "")
                {
                    votoGovernador = txtVoto.Text;
                    txtVoto.Text = "";
                    lblCargoParaVoto.Text = "Presidente";
                }
                else if(votoPresidente == "")
                {
                    votoPresidente = txtVoto.Text;
                    txtVoto.Text = "";
                    votoDepFederal = "";
                    votoDepEstOuDist = "";
                    votoSenador = "";
                    votoGovernador = "";
                    votoPresidente = "";

                    lblCargoParaVoto.Text = "Deputado Federal";
                }
            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtVoto.Text = "";
        }
    }
}
