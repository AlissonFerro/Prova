using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Prova : Form
    {
        static string[] gabarito = new string[LogicaProva.qtdQuestoes];
        int i = 0;
        int j = 0;

        public Prova()
        {
            InitializeComponent();
            btnFinalizar.Visible = false;
            lblEnunciado.Multiline = true;
            lblEnunciado.ScrollBars = ScrollBars.Both;

            mudaQuestao();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            gabarito[i] = verificaSelecao();
            if (i>=8)
            {
                btnProximo.Visible = false;
                btnFinalizar.Visible = true;
            }
            j = 0;
            
            i++;
            mudaQuestao();
        }
        private void mudaQuestao()
        {

            LogicaProva.GeraQuestoes();
 
            lblNum.Text = (i + 1).ToString();
            lblEnunciado.Text = LogicaProva.questoes[i].enunciado;
            rButtonA.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonB.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonC.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonD.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonE.Text = LogicaProva.questoes[i].alternativas[j++];

            escondeAlternativa(rButtonA);
            escondeAlternativa(rButtonB);
            escondeAlternativa(rButtonC);
            escondeAlternativa(rButtonD);
            escondeAlternativa(rButtonE);
        }
        private string verificaSelecao()
        {
            string opcao;
            if (rButtonA.Checked)
            {
                opcao = "A";
                rButtonA.Checked = false;
            }
            else if (rButtonB.Checked)
            {
                opcao = "B";
                rButtonB.Checked = false;
            }
            else if (rButtonC.Checked)
            {
                opcao = "C";
                rButtonC.Checked = false;
            }
            else if (rButtonD.Checked)
            {
                opcao = "D";
                rButtonD.Checked = false;
            }
            else if (rButtonE.Checked)
            {
                opcao = "E";
                rButtonE.Checked = false;
            }
            else
            {
                opcao = "X";
            }

            return opcao;
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            gabarito[i] = verificaSelecao();
            this.Hide();
            Resultado resultado = new Resultado();
            resultado.Show();
        }

        private void escondeAlternativa(RadioButton radioButton)
        {
            if (radioButton.Text.Equals(""))
            {
                radioButton.Visible = false;
            }
            else
                radioButton.Visible = true;
        }

        public static string[] GetGabarito()
        {
            return gabarito;
        }

    }
}
