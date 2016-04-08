using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancoEPO3T1 {
    public partial class CadastroCliente : Form {

        Input mainForm = new Input();

        public CadastroCliente(Input i) {
            InitializeComponent();
            this.mainForm = i;
        }

        protected override void OnClosing(CancelEventArgs e) {
            this.mainForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtNome.ResetText();
            txtSaldoInicial.ResetText();
            txtTelefone.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.mainForm.Show();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e) {
            try {
                Codigo generator = new Codigo(this.mainForm);
                Cliente temp = new Cliente(mainForm, this.txtNome.Text, this.txtTelefone.Text);
                temp.contaCorrente.First().Transacoes.Add(new Deposito(Convert.ToDouble(this.txtSaldoInicial.Text), temp, mainForm));
                this.mainForm.clientes.Add(temp);
                MessageBox.Show("Cliente Cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } catch (Exception exc) {
                MessageBox.Show(exc.ToString(), "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
