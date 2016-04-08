using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancoEPO3T1 {
    public partial class ListaClientes : Form {
        Input mainForm = new Input();
        public ListaClientes(Input i) {
            InitializeComponent();
            this.mainForm = i;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            mainForm.Show();
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e) {
            mainForm.Show();
        }

        private void ListaClientes_Load(object sender, EventArgs e) {
            this.dGVConsulta.AutoGenerateColumns = true;
            this.dGVConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dGVConsulta.AllowUserToAddRows = false;
            this.dGVConsulta.DataSource = new BindingList<Cliente>(mainForm.clientes);
            this.dGVConsulta.Columns.Remove("Conta");
            this.dGVConsulta.Columns["Saldo"].ReadOnly = true;
            this.dGVConsulta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void recarregarToolStripMenuItem_Click(object sender, EventArgs e) {
            ListaClientes_Load(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in this.dGVConsulta.SelectedRows) {
                mainForm.clientes.RemoveAt(row.Index);
            } ListaClientes_Load(sender, e);
        }
    }
}
