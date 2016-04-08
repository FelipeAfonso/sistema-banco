using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoEPO3T1 {
    public class Transacao {
        protected string codigo;
        protected double valor;
        public string Tipo { get; protected set; }
        public static int qtdTransacoes = 0;
        protected Cliente origem = new Cliente();
        protected Cliente destino = new Cliente();
        public string Codigo_Destino { get; protected set; }
        public string Codigo_Origem { get; protected set; }


        public string Codigo { get; protected set; }

        protected string setCodigo(Input mF) {
            Codigo generator = new Codigo(mF);
            return generator.gerarCodigoValido('T');
        }

        public double Valor { get { return valor; } protected set { valor = value; } }

        private bool ValidacaoDigitos(string s) {
            foreach (char c in s) {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public Transacao() { qtdTransacoes++; }
    }
}
    