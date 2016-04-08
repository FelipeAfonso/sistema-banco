using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaBancoEPO3T1 {
    class Deposito : Transacao {

        public Deposito(double v, Cliente d, Input mF) {
            this.valor = v;
            this.destino = d;
            this.Tipo = "Depósito";
            this.destino.contaCorrente.First().Saldo += v;
            this.Codigo_Destino = destino.Codigo_Conta_Corrente;
            this.Codigo = setCodigo(mF);
        }
    }
}
