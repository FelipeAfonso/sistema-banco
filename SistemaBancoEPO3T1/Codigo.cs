using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaBancoEPO3T1 {
    public class Codigo {

        Input input;
        Random r = new Random();

        public Codigo(Input i) {
            this.input = i;
        }

        private string criarCodigo() {
            string codigo = "";
            int count = 0;
            for(int x=0; x<4;x++) {
                codigo += r.Next(0, 10).ToString();
                count++;
            }
            return codigo;
        }

        public string gerarCodigoValido(char tipo) {
            if (tipo == 'c' || tipo == 'C') { //Cliente
                string codigo = criarCodigo();
                int i = 0;
                while (i <= input.clientes.Count) {
                    if (input.clientes.Count == 0) i++;
                    foreach (Cliente c in input.clientes) {
                        if (codigo == c.Codigo) {
                            codigo = criarCodigo();
                            i = 0;
                        } else i++;
                    }
                }
                return codigo;
            } else if (tipo == 'T' || tipo == 't') { // Transação
                string codigo = criarCodigo();
                int i = 0;
                while (i <= input.clientes.Count) {
                    if (input.clientes.Count == 0) i++;
                    foreach (Cliente c in input.clientes) {
                        foreach (ContaCorrente cC in c.contaCorrente) {
                            foreach (Transacao t in cC.Transacoes) {
                                if (t.Codigo == codigo) {
                                    codigo = criarCodigo();
                                    i = 0;
                                } else i++;
                            }
                        }
                    }
                }
                return codigo;
            } else { //Conta Corrente
                string codigo = criarCodigo();
                int i = 0;
                while (i <= input.clientes.Count) {
                    if (input.clientes.Count == 0) i++;
                    foreach (Cliente c in input.clientes) {
                        foreach (ContaCorrente cC in c.contaCorrente) {
                            if (codigo == cC.codigo) {
                                codigo = criarCodigo();
                                i = 0;
                            } else i++;
                        }
                    }
                }
                return codigo;
            }
        }
    }
}
