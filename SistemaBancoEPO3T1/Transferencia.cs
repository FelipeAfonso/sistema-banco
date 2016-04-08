using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaBancoEPO3T1 {
    class Transferencia : Transacao {

        public Transferencia(double v, Cliente o, Cliente d, Input mF) {
            this.valor = v;
            this.origem = o;
            this.destino = d;
            this.Tipo = "Transferência";
            this.destino.contaCorrente.First().Saldo += v;
            this.origem.contaCorrente.First().Saldo -= v;
            this.Codigo_Destino = destino.Codigo_Conta_Corrente;
            this.Codigo_Origem = origem.Codigo_Conta_Corrente;
            this.Codigo = setCodigo(mF);
        }
    }
}
