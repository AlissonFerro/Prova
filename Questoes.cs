using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Questao
    {
        public int id_Questao;
        public string enunciado;
        public string[] alternativas = new string[5];
        public string gabarito;

        public string GetGabarito()
        {
            return gabarito;
        }

    }
}
