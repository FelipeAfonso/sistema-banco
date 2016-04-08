using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancoEPO3T1 {
    public partial class Transacoes : Form {
        Input mainForm;
        public Transacoes(Input i) {
            InitializeComponent();
            mainForm = i;
        }
        protected override void OnClosing(CancelEventArgs e) {
            this.mainForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.mainForm.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtDestino.ResetText();
            txtOrigem.ResetText();
            txtValor.ResetText();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Para Depósitos deixe em branco a Origem\nPara Saques deixe em branco o Destino", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            if (txtDestino.Text == "" && txtOrigem.Text != "" && txtValor.Text != "") { //Saque
                try {
                    int index = -1;
                    Cliente clienteTemp = new Cliente();
                    foreach (Cliente cliente in mainForm.clientes) {
                        if (cliente.Codigo_Conta_Corrente == txtOrigem.Text) {
                            clienteTemp = cliente;
                            index = mainForm.clientes.IndexOf(cliente);
                        }
                    }
                    Saque saqueTemp = new Saque(Convert.ToDouble(txtValor.Text), clienteTemp, mainForm);
                    clienteTemp.contaCorrente.First().Transacoes.Add(saqueTemp);
                    mainForm.clientes.RemoveAt(index);
                    mainForm.clientes.Add(clienteTemp);
                    MessageBox.Show("Transação cadastrada com sucesso", "BankSys - Transação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } catch {
                    MessageBox.Show("Conta Corrente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (txtOrigem.Text == "" && txtDestino.Text != "" && txtValor.Text != "") { //Depósito
                try {
                    int index = -1;
                    Cliente clienteTemp = new Cliente();
                    foreach (Cliente cliente in mainForm.clientes) {
                        if (cliente.Codigo_Conta_Corrente == txtDestino.Text) {
                            clienteTemp = cliente;
                            index = mainForm.clientes.IndexOf(cliente);
                        }
                    }
                    Deposito depositoTemp = new Deposito(Convert.ToDouble(txtValor.Text), clienteTemp, mainForm);
                    clienteTemp.contaCorrente.First().Transacoes.Add(depositoTemp);
                    mainForm.clientes.RemoveAt(index);
                    mainForm.clientes.Add(clienteTemp);
                    MessageBox.Show("Transação cadastrada com sucesso", "BankSys - Transação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } catch {
                    MessageBox.Show("Conta Corrente não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (txtOrigem.Text != "" && txtDestino.Text != "" && txtValor.Text != "") { //Transferência
                try {
                    int indexO = -1;
                    int indexD = -1;
                    Cliente clienteTempOrigem = new Cliente();
                    Cliente clienteTempDestino = new Cliente();
                    foreach (Cliente cliente in mainForm.clientes) {
                        if (cliente.Codigo_Conta_Corrente == txtDestino.Text) {
                            clienteTempDestino = cliente;
                            indexD = mainForm.clientes.IndexOf(cliente);
                        }
                        if (cliente.Codigo_Conta_Corrente == txtOrigem.Text) {
                            clienteTempOrigem = cliente;
                            indexO = mainForm.clientes.IndexOf(cliente);
                        }
                    }
                    Transferencia transferenciaTemp = new Transferencia(Convert.ToDouble(txtValor.Text), clienteTempOrigem, clienteTempDestino, mainForm);
                    clienteTempOrigem.contaCorrente.First().Transacoes.Add(transferenciaTemp);
                    clienteTempDestino.contaCorrente.First().Transacoes.Add(transferenciaTemp);
                    mainForm.clientes.RemoveAt(indexD);
                    mainForm.clientes.RemoveAt(indexO);
                    mainForm.clientes.Add(clienteTempOrigem);
                    mainForm.clientes.Add(clienteTempDestino);
                    MessageBox.Show("Transação cadastrada com sucesso", "BankSys - Transação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } catch {
                    MessageBox.Show("Conta Corrente não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Faltam dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
