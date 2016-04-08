using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaBancoEPO3T1 {
    public class Cliente {
        private string codigo;
        private string nome;
        private string telefone;
        public List<ContaCorrente> contaCorrente = new List<ContaCorrente>();
        private double saldo;

        /* Getters & Setters */
        public string Codigo {
            get { return codigo; }
            private set { if (ValidacaoDigitos(value)) this.codigo = value;
                          else throw new System.ArgumentException("Codigo Cliente: Caractere invalido!");
            }
        }

        public string Nome {
            get { return nome; }
            set { if (validacaoLetras(value)) nome = value;
                  else throw new System.ArgumentException("Nome Cliente: Caractere invalido!");
            }
        }

        public string Telefone {
            get { return telefone; }
            set { if (ValidacaoDigitos(value)) telefone = value;
                  else throw new System.ArgumentException("Telefone Cliente: Caractere invalido!");
            }
        }

        public ContaCorrente Conta {
            get { return contaCorrente.ElementAt(0); }
            set { contaCorrente.Insert(0, value); }
        }

        public string Codigo_Conta_Corrente {
            get { return contaCorrente.ElementAt(0).codigo; }
        }

        public double Saldo { get { return saldo; } set { this.saldo = value; } }

        // Método usado para validação nos setters anteriores
        private bool ValidacaoDigitos(string s) {
            foreach (char c in s) {
                if (!char.IsDigit(c))
                    if (c != ' ' && c != '(' && c != ')') {
                        return false;
                    }
            }
            return true;
        }

        private bool validacaoLetras(string s) {
            foreach (char c in s) {
                if (!char.IsLetter(c))
                    if (c != ' ' && c != '_' && c != '-')
                        return false;
            }
            return true;
        }

        /* Construtor */
        public Cliente(Input mainForm, string nome, string telefone) {
            Codigo generator = new Codigo(mainForm);
            this.codigo = generator.gerarCodigoValido('C');
            this.Nome = nome;
            this.Telefone = telefone;
            this.contaCorrente.Add(new ContaCorrente(this, generator));
            this.saldo = this.contaCorrente.First().Saldo;
        }

        public Cliente() {

        }
    }
}
