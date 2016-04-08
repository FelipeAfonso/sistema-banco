using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaBancoEPO3T1 {
    class Saque : Transacao {

        public Saque(double v, Cliente o, Input mF) {
            this.valor = v;
            this.origem = o;
            this.Tipo = "Saque";
            origem.contaCorrente.First().Saldo -= v;
            this.Codigo_Origem = origem.Codigo_Conta_Corrente;
            this.Codigo = setCodigo(mF);
        }
    }
}
