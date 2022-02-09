using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdicionarQuestoes : Form
    {
        private string[] alternativas = { "A", "B", "C", "D", "E" };
        public AdicionarQuestoes()
        {
            InitializeComponent();
            foreach (string alternativas in alternativas)
            {
                comboBox.Items.Add(alternativas);
            }
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Alternativa correta não atribuída");
            }
            
            string strSQL = "INSERT INTO QUESTOES(NumQuestao, Enunciado, AlternativaA, AlternativaB,AlternativaC,AlternativaD, AlternativaE,Gabarito, Tema) " +
                "VALUES(@NUMQUESTAO, @ENUNCIADO, @ALTERNATIVAA, @ALTERNATIVAB, @ALTERNATIVAC, @ALTERNATIVAD, @ALTERNATIVAE, @GABARITO, @TEMA)";
            SqlCommand comando = new SqlCommand(strSQL, LogicaProva.conexao);
            LogicaProva.conexao.Open();

            comando.Parameters.AddWithValue("@NUMQUESTAO", txtNumQuestao.Text);
            comando.Parameters.AddWithValue("@ENUNCIADO", txtEnunciado.Text);
            comando.Parameters.AddWithValue("@ALTERNATIVAA", txtAltA.Text);
            comando.Parameters.AddWithValue("@ALTERNATIVAB", txtAltB.Text);
            comando.Parameters.AddWithValue("@ALTERNATIVAC", txtAltC.Text);
            comando.Parameters.AddWithValue("@ALTERNATIVAD", txtAltD.Text);
            comando.Parameters.AddWithValue("@ALTERNATIVAE", txtAltE.Text);
            comando.Parameters.AddWithValue("@GABARITO", comboBox.Text);
            comando.Parameters.AddWithValue("@TEMA", txtProva.Text);

            comando.ExecuteNonQuery();

            LogicaProva.conexao.Close();
            limpaText();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void limpaText()
        {
            txtNumQuestao.Clear();
            txtAltA.Clear();
            txtAltB.Clear();
            txtAltC.Clear();
            txtAltD.Clear();
            txtAltE.Clear();
            txtEnunciado.Clear();
            if (checkLimpar.Checked)
            {
                txtProva.Clear();
            }
            comboBox.SelectedIndex = -1;

        }
    }
}
