using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoEPO3T1 {
    public class ContaCorrente {
        private double saldo;

        public string codigo { get; private set; }

        public List<Transacao> Transacoes = new List<Transacao>();

        private Cliente usuario;

        /* Getters & Setters */

        public double Saldo { get { return saldo; } set { this.usuario.Saldo = value; this.saldo = value; } }

        // Método usado para validação nos setters anteriores
        private bool ValidacaoDigitos(string s) {
            foreach (char c in s) {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public Cliente Usuario {
            get { return usuario; }
        }

        /* Construtor */
        public ContaCorrente(Cliente u, Codigo generator) {
            this.codigo = generator.gerarCodigoValido('R');
            this.usuario = u;
            this.Saldo = 0;
        }
    }
}
