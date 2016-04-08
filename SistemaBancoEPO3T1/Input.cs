using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancoEPO3T1 {
    public partial class Input : Form {

        public List<Cliente> clientes = new List<Cliente>();

        public Input() {
            InitializeComponent();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Developed by:\n              Felipe Munhoz Afonso\n              "+
                "Lucas Alves Zandoná\n              Renan Kaic Lopes\n"
                                    + "              Luis Henrique Franco Camargo\n              Bruno Tomaz\n(2015, May)" +
                " - IFSP Piracicaba","Developer Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CadastroCliente cadastroCliente = new CadastroCliente(this);
            cadastroCliente.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            string codCliente = Microsoft.VisualBasic.Interaction.InputBox("Insira o código do cliente a ser removido:", "BankSys - Remover Cliente");
            try {
                foreach (Cliente cliente in this.clientes) {
                    if (codCliente == cliente.Codigo) {
                        clientes.Remove(cliente);
                    }
                }
            } catch {
                MessageBox.Show("O Cliente inserido não pôde ser encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e) {
            ListaTransacoes listaTransacoes = new ListaTransacoes(this, 'D',sender, e);
            listaTransacoes.Show();
            this.Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e) {
            Transacoes transfer = new Transacoes(this);
            transfer.Show();
            this.Hide();
        }

        private void tabTransacoes_Click(object sender, EventArgs e) {

        }

        private void btnPrintTrans_Click(object sender, EventArgs e) {
            ListaTransacoes listaTransacoes = new ListaTransacoes(this);
            listaTransacoes.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string codCliente = Microsoft.VisualBasic.Interaction.InputBox("Insira o código ou o nome do cliente a ser consultado:", "BankSys - Consultar Cliente");
            try {
                foreach (Cliente cliente in this.clientes) {
                    if (codCliente == cliente.Codigo || codCliente == cliente.Nome) {
                        MessageBox.Show("Código: " + cliente.Codigo + "\nNome: " + cliente.Nome +
                                        "\nTelefone: " + cliente.Telefone + "\nCódigo da Conta Corrente: " +
                                        cliente.Codigo_Conta_Corrente + "\nSaldo: " + cliente.Saldo, "BankSys - Consultar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch {
                MessageBox.Show("O Cliente inserido não pôde ser encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            ListaClientes consultar = new ListaClientes(this);
            consultar.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string codCliente = Microsoft.VisualBasic.Interaction.InputBox("Insira o código ou o nome do cliente a ser consultado:", "BankSys - Consultar Cliente");
            try {
                foreach (Cliente cliente in this.clientes) {
                    if (codCliente == cliente.Codigo || codCliente == cliente.Nome) {
                        DialogResult alterar = MessageBox.Show("Deseja alterar este cliente?\nCódigo: " + cliente.Codigo + "\nNome: " + cliente.Nome +
                                        "\nTelefone: " + cliente.Telefone + "\nCódigo da Conta Corrente: " +
                                        cliente.Codigo_Conta_Corrente + "\nSaldo: " + cliente.Saldo, "BankSys - Consultar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (alterar == DialogResult.Yes) {
                            string newName = Microsoft.VisualBasic.Interaction.InputBox("Insira o novo nome para " + cliente.Nome, "BankSys - Consultar Cliente");
                            string newTelefone = Microsoft.VisualBasic.Interaction.InputBox("Insira o novo telefone para " + cliente.Nome, "BankSys - Consultar Cliente");
                            try {
                                cliente.Nome = newName;
                                cliente.Telefone = newTelefone;
                            } catch (Exception exc) {
                                MessageBox.Show("Erro inesperado: " + exc.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            } catch {
                MessageBox.Show("O Cliente inserido não pôde ser encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e) {
            ListaTransacoes listaTransacoes = new ListaTransacoes(this, 'T', sender, e);
            listaTransacoes.Show();
            this.Hide();
        }

        private void btnSaque_Click(object sender, EventArgs e) {
            ListaTransacoes listaTransacoes = new ListaTransacoes(this, 'T', sender, e);
            listaTransacoes.Show();
            this.Hide();
        }
    }
}
