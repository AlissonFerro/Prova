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
    public partial class Resultado : Form
    {
        string[] gabaritoProva = new string[LogicaProva.qtdQuestoes];
        string[] gabaritoOficial = new string[LogicaProva.qtdQuestoes];
        public Resultado()
        {
            InitializeComponent();
            gabaritoProva = Prova.GetGabarito();
            SetLabel(groupBox1, gabaritoProva);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Correcao(Label label, Label label2)
        {            
            for (int i = 0; i < gabaritoProva.Length; i++)
            {
                gabaritoProva[i] = LogicaProva.questoes[i].gabarito;
            }
                        
            if (label.Text == label2.Text)
            {
                label.ForeColor = Color.Green;
                LogicaProva.Acertou();
            }
            else
            {
                label.ForeColor = Color.Red;
            }
        }

        private void SetLabel(GroupBox currentGB, string[] newUnit)
        {
            int i = 0;
            foreach (Label ctrl in currentGB.Controls.OfType<Label>())
            {
                ctrl.Text = newUnit[i].ToString();
                i++;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = false;
            btnVoltar.Visible = false;

            lblNotaText.Visible = true;
            lblNotaNum.Visible = true;
            lblGabarito.Visible = true;
            groupBox2.Visible = true;

            gabaritoOficial = LogicaProva.GetGabarito();

            SetLabel(groupBox2, gabaritoOficial);

            Correcao(lbl01Resp, lbl01Gab);
            Correcao(lbl02Resp, lbl02Gab);
            Correcao(lbl03Resp, lbl03Gab);
            Correcao(lbl04Resp, lbl04Gab);
            Correcao(lbl05Resp, lbl05Gab);
            Correcao(lbl06Resp, lbl06Gab);
            Correcao(lbl07Resp, lbl07Gab);
            Correcao(lbl08Resp, lbl08Gab);
            Correcao(lbl09Resp, lbl09Gab);
            Correcao(lbl10Resp, lbl10Gab);

            
            lblNotaNum.Text = String.Format("{0:0.0}", LogicaProva.GetAcertos());
            if (LogicaProva.GetAcertos().Equals(LogicaProva.qtdQuestoes))
            {
                MessageBox.Show("Parabéns você acertou toda a prova");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prova prova = new Prova();
            prova.Show();
        }
    }
}
