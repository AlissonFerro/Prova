using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class LogicaProva
    {
        private static int acertos = 0;
        public static int qtdQuestoes = 10;

        public static List<Questao> questoes = new List<Questao>();
        public static int[] IdQuestoes = new int[10];
        public static SqlConnection conexao = new SqlConnection("Server = CCH02LABF29\\SQLEXPRESS; Database = PROVA; Trusted_Connection = True;");

        public static void buscaEnunciado(int numID)
        {
            string stringEnunciado = "SELECT ID_QUESTAO, Enunciado, AlternativaA, AlternativaB, AlternativaC, " +
                "AlternativaD, AlternativaE, Gabarito FROM QUESTOES WHERE ID_QUESTAO = @ID";

            SqlCommand lerEnunciado = new SqlCommand(stringEnunciado, conexao);
            conexao.Open();
            lerEnunciado.Parameters.AddWithValue("@ID", numID.ToString());
            SqlDataReader dataReaderEnun = lerEnunciado.ExecuteReader();

            while (dataReaderEnun.Read())
            {
                Questao questao1 = new Questao();

                questao1.id_Questao = Convert.ToInt32(dataReaderEnun[0]);
                questao1.enunciado = (Convert.ToString(dataReaderEnun[1]));
                questao1.alternativas[0] = Convert.ToString(dataReaderEnun[2]);
                questao1.alternativas[1] = Convert.ToString(dataReaderEnun[3]);
                questao1.alternativas[2] = Convert.ToString(dataReaderEnun[4]);
                questao1.alternativas[3] = Convert.ToString(dataReaderEnun[5]);
                questao1.alternativas[4] = Convert.ToString(dataReaderEnun[6]);
                questao1.gabarito = Convert.ToString(dataReaderEnun[7]);
                questoes.Add(questao1);
            }
            conexao.Close();

        }

        public static int CountSql()
        {
            conexao.Open();
            string stringCount = "SELECT COUNT(ID_QUESTAO)FROM QUESTOES";
            SqlCommand lerCount = new SqlCommand(stringCount, conexao);
            var dataReaderCount = lerCount.ExecuteScalar();
            int qtdQuestoes = Convert.ToInt32(dataReaderCount);
            conexao.Close();
            return qtdQuestoes;
        }
        

        public static int getAcertos()
        {
            return acertos;
        }

        public static void acertou()
        {
            acertos++;
        }

        public static string[] GetGabarito()
        {
            
            string[] corretas = new string[qtdQuestoes];
            for (int i = 0; i < qtdQuestoes; i++)
            {
                corretas[i] = questoes[i].gabarito;
            }

            return corretas;
        }

        public static int GeraAleatorio(int numMax)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(numMax);
            
            return aleatorio;
        }

        public static List<Questao> GeraQuestoes()
        {
            buscaEnunciado(GeraAleatorio(CountSql()));
            return questoes;
        }

    }
}
