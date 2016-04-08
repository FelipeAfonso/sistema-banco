namespace SistemaBancoEPO3T1 {
    partial class Input {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.tabClienteTransacoes = new System.Windows.Forms.TabControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabTransacoes = new System.Windows.Forms.TabPage();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnPrintTrans = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.tabClienteTransacoes.SuspendLayout();
            this.cms.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabTransacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClienteTransacoes
            // 
            this.tabClienteTransacoes.ContextMenuStrip = this.cms;
            this.tabClienteTransacoes.Controls.Add(this.tabCliente);
            this.tabClienteTransacoes.Controls.Add(this.tabTransacoes);
            this.tabClienteTransacoes.Location = new System.Drawing.Point(-1, -1);
            this.tabClienteTransacoes.Name = "tabClienteTransacoes";
            this.tabClienteTransacoes.SelectedIndex = 0;
            this.tabClienteTransacoes.Size = new System.Drawing.Size(197, 168);
            this.tabClienteTransacoes.TabIndex = 0;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(105, 26);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.Color.Transparent;
            this.tabCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCliente.Controls.Add(this.btnPrint);
            this.tabCliente.Controls.Add(this.btnRemove);
            this.tabCliente.Controls.Add(this.btnUpdate);
            this.tabCliente.Controls.Add(this.btnSearch);
            this.tabCliente.Controls.Add(this.btnAdd);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(189, 142);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Clientes";
            // 
            // btnPrint
            // 
            this.btnPrint.ContextMenuStrip = this.cms;
            this.btnPrint.Location = new System.Drawing.Point(6, 98);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(176, 40);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Lista de Clientes Cadastros";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ContextMenuStrip = this.cms;
            this.btnRemove.Location = new System.Drawing.Point(97, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remover Cliente";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ContextMenuStrip = this.cms;
            this.btnUpdate.Location = new System.Drawing.Point(97, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Atualizar Cadastro";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ContextMenuStrip = this.cms;
            this.btnSearch.Location = new System.Drawing.Point(6, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Consultar Cliente";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ContextMenuStrip = this.cms;
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Cadastrar Cliente";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabTransacoes
            // 
            this.tabTransacoes.BackColor = System.Drawing.Color.Transparent;
            this.tabTransacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTransacoes.ContextMenuStrip = this.cms;
            this.tabTransacoes.Controls.Add(this.btnTransfer);
            this.tabTransacoes.Controls.Add(this.btnPrintTrans);
            this.tabTransacoes.Controls.Add(this.btnTransferencia);
            this.tabTransacoes.Controls.Add(this.btnSaque);
            this.tabTransacoes.Controls.Add(this.btnDeposito);
            this.tabTransacoes.Location = new System.Drawing.Point(4, 22);
            this.tabTransacoes.Name = "tabTransacoes";
            this.tabTransacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransacoes.Size = new System.Drawing.Size(189, 142);
            this.tabTransacoes.TabIndex = 1;
            this.tabTransacoes.Text = "Transações";
            this.tabTransacoes.Click += new System.EventHandler(this.tabTransacoes_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.ContextMenuStrip = this.cms;
            this.btnTransfer.Location = new System.Drawing.Point(6, 6);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(176, 40);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transferir";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnPrintTrans
            // 
            this.btnPrintTrans.ContextMenuStrip = this.cms;
            this.btnPrintTrans.Location = new System.Drawing.Point(97, 98);
            this.btnPrintTrans.Name = "btnPrintTrans";
            this.btnPrintTrans.Size = new System.Drawing.Size(85, 40);
            this.btnPrintTrans.TabIndex = 3;
            this.btnPrintTrans.Text = "Lista de Transações";
            this.btnPrintTrans.UseVisualStyleBackColor = true;
            this.btnPrintTrans.Click += new System.EventHandler(this.btnPrintTrans_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.ContextMenuStrip = this.cms;
            this.btnTransferencia.Location = new System.Drawing.Point(97, 52);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(85, 40);
            this.btnTransferencia.TabIndex = 2;
            this.btnTransferencia.Text = "Lista de Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.ContextMenuStrip = this.cms;
            this.btnSaque.Location = new System.Drawing.Point(6, 98);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(85, 40);
            this.btnSaque.TabIndex = 1;
            this.btnSaque.Text = "Lista de Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.ContextMenuStrip = this.cms;
            this.btnDeposito.Location = new System.Drawing.Point(6, 52);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(85, 40);
            this.btnDeposito.TabIndex = 4;
            this.btnDeposito.Text = "Lista de Depósitos";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 167);
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.tabClienteTransacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(209, 205);
            this.MinimumSize = new System.Drawing.Size(209, 205);
            this.Name = "Input";
            this.Text = "BankSys";
            this.tabClienteTransacoes.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabTransacoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabClienteTransacoes;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabTransacoes;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrintTrans;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.Button btnTransfer;

    }
}