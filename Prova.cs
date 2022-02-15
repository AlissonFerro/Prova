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
            LogicaProva.GeraAleatorio(LogicaProva.CountSql());
            btnFinalizar.Visible = false;
            btnVoltar.Visible = false;
            lblEnunciado.Multiline = true;
            lblEnunciado.ScrollBars = ScrollBars.Both;
            MudaQuestao();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            btnProximo.Visible=true;
            btnFinalizar.Visible=false;
            i--;
            if (i == 0)
            {
                btnVoltar.Visible=false;
            }
            j = 0;
            MudaQuestao();
            VoltaAlternativa();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            gabarito[i] = VerificaSelecao();
            if (i>=0)
            {
                btnVoltar.Visible=true;
            }
            if (i>=(LogicaProva.qtdQuestoes-2))
            {
                btnProximo.Visible = false;
                btnFinalizar.Visible = true;
            }
            j = 0;
            
            i++;
            MudaQuestao();
            VoltaAlternativa();
        }
        private void BtnFinalizar_Click_1(object sender, EventArgs e)
        {
            gabarito[i] = VerificaSelecao();
            this.Hide();
            Resultado resultado = new Resultado();
            resultado.Show();
        }
        private void MudaQuestao()
        {

            LogicaProva.GeraQuestoes(i);
            //MessageBox.Show(LogicaProva.numAleatórios[i].ToString());
            rButtonA.Checked = false;
 
            lblNum.Text = (i + 1).ToString();
            lblEnunciado.Text = LogicaProva.questoes[i].enunciado;
            rButtonA.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonB.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonC.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonD.Text = LogicaProva.questoes[i].alternativas[j++];
            rButtonE.Text = LogicaProva.questoes[i].alternativas[j++];

           
            EscondeAlternativa(rButtonA);
            EscondeAlternativa(rButtonB);
            EscondeAlternativa(rButtonC);
            EscondeAlternativa(rButtonD);
            EscondeAlternativa(rButtonE);
            VoltaAlternativa();
        }
        private string VerificaSelecao()
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


        private void EscondeAlternativa(RadioButton radioButton)
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

        public void VoltaAlternativa()
        {
            if (gabarito[i]=="A")
            {
                rButtonA.Checked = true;
            }
            else if (gabarito[i] == "B")
            {
                rButtonB.Checked = true;
            }
            else if (gabarito[i] == "C")
            {
                rButtonC.Checked = true;
            }
            else if (gabarito[i] == "D")
            {
                rButtonD.Checked = true;
            }
            else if (gabarito[i] == "E")
            {
                rButtonE.Checked = true;
            }
        }


    }
}
