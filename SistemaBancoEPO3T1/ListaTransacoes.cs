using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancoEPO3T1 {
    public partial class ListaTransacoes : Form {
        Input mainForm;
        BindingList<Transacao> listaT = new BindingList<Transacao>();
        public ListaTransacoes(Input i) {
            InitializeComponent();
            this.mainForm = i;
        }

        public ListaTransacoes(Input i, char filtro, object sender, EventArgs e) {
            InitializeComponent();
            this.mainForm = i;
            if (filtro == 'D')
                this.btnFiltroDeposito_Click(sender, e);
            else if (filtro == 'S')
                this.btnFiltroSaque_Click(sender, e);
            else if (filtro == 'T')
                this.btnFiltroTransferencia_Click(sender, e);

        }
        protected override void OnClosing(CancelEventArgs e) {
            this.mainForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.mainForm.Show();
            this.Close();
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.btnFiltroDeposito_Click(sender, e);
        }

        private void ListaTransacoes_Load(object sender, EventArgs e) {
            this.listaT.Clear();
            this.dGV_ConsultaTransacao.AutoGenerateColumns = true;
            this.dGV_ConsultaTransacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ConsultaTransacao.AllowUserToAddRows = false;
            foreach (Cliente cliente in mainForm.clientes) {
                foreach (Transacao transacao in cliente.contaCorrente.First().Transacoes) {
                    listaT.Add(transacao);
                }
            }
            this.dGV_ConsultaTransacao.DataSource = listaT;
            this.dGV_ConsultaTransacao.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnFiltroDeposito_Click(object sender, EventArgs e) {
            BindingList<Transacao> depositosTemp = new BindingList<Transacao>();
            foreach (Transacao t in listaT) {
                if (t.Tipo == "Depósito")
                    depositosTemp.Add(t);
            }
            dGV_ConsultaTransacao.DataSource = depositosTemp;
        }

        private void recarregarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.ListaTransacoes_Load(sender, e);
        }

        private void btnFiltroSaque_Click(object sender, EventArgs e) {
            BindingList<Transacao> saquesTemp = new BindingList<Transacao>();
            foreach (Transacao t in listaT) {
                if (t.Tipo == "Saque")
                    saquesTemp.Add(t);
            }
            dGV_ConsultaTransacao.DataSource = saquesTemp;
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e) {
            this.btnFiltroSaque_Click(sender, e);
        }

        private void btnFiltroTransferencia_Click(object sender, EventArgs e) {
            BindingList<Transacao> transferenciasTemp = new BindingList<Transacao>();
            foreach (Transacao t in listaT) {
                if (t.Tipo == "Transferência")
                    transferenciasTemp.Add(t);
            }
            dGV_ConsultaTransacao.DataSource = transferenciasTemp;
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e) {
            this.btnFiltroTransferencia_Click(sender, e);
        }

        private void tudoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.ListaTransacoes_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string consulta = Microsoft.VisualBasic.Interaction.InputBox("Insira o código ou o nome a ser consultado", "BankSys - Consulta");
            BindingList<Transacao> consultaTemp = new BindingList<Transacao>();
            foreach (Transacao t in listaT) {
                if (t.Codigo_Destino == consulta || t.Codigo_Origem == consulta || t.Codigo == consulta) {
                    consultaTemp.Add(t);
                }
                foreach (Cliente c in mainForm.clientes) {
                    if (c.Nome == consulta)
                        foreach (Transacao tran in c.contaCorrente.First().Transacoes) {
                            consultaTemp.Add(tran);
                        }
                }
            }
            dGV_ConsultaTransacao.DataSource = consultaTemp;
        }
    }
}
