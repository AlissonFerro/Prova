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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AdicionarQuestoes adicionar = new AdicionarQuestoes();
            this.Hide();
            adicionar.Show();
        }

        private void btnProva_Click(object sender, EventArgs e)
        {
            Prova prova = new Prova();
            this.Hide();
            prova.Show();
        }
    }
}
