namespace SistemaBancoEPO3T1 {
    partial class ListaTransacoes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTransacoes));
            this.cmsReload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recarregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFiltroDeposito = new System.Windows.Forms.Button();
            this.panelTransferencias = new System.Windows.Forms.Panel();
            this.btnFiltroTransferencia = new System.Windows.Forms.Button();
            this.btnFiltroSaque = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dGV_ConsultaTransacao = new System.Windows.Forms.DataGridView();
            this.cmsReload.SuspendLayout();
            this.panelTransferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ConsultaTransacao)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsReload
            // 
            this.cmsReload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recarregarToolStripMenuItem,
            this.filtrarPorToolStripMenuItem});
            this.cmsReload.Name = "cmsReload";
            this.cmsReload.Size = new System.Drawing.Size(131, 48);
            // 
            // recarregarToolStripMenuItem
            // 
            this.recarregarToolStripMenuItem.Name = "recarregarToolStripMenuItem";
            this.recarregarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.recarregarToolStripMenuItem.Text = "Recarregar";
            this.recarregarToolStripMenuItem.Click += new System.EventHandler(this.recarregarToolStripMenuItem_Click);
            // 
            // filtrarPorToolStripMenuItem
            // 
            this.filtrarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depósitoToolStripMenuItem,
            this.saqueToolStripMenuItem,
            this.transferênciaToolStripMenuItem,
            this.tudoToolStripMenuItem});
            this.filtrarPorToolStripMenuItem.Name = "filtrarPorToolStripMenuItem";
            this.filtrarPorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.filtrarPorToolStripMenuItem.Text = "Filtrar por";
            // 
            // depósitoToolStripMenuItem
            // 
            this.depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            this.depósitoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depósitoToolStripMenuItem.Text = "Depósito";
            this.depósitoToolStripMenuItem.Click += new System.EventHandler(this.depósitoToolStripMenuItem_Click);
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saqueToolStripMenuItem.Text = "Saque";
            this.saqueToolStripMenuItem.Click += new System.EventHandler(this.saqueToolStripMenuItem_Click);
            // 
            // transferênciaToolStripMenuItem
            // 
            this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transferênciaToolStripMenuItem.Text = "Transferência";
            this.transferênciaToolStripMenuItem.Click += new System.EventHandler(this.transferênciaToolStripMenuItem_Click);
            // 
            // tudoToolStripMenuItem
            // 
            this.tudoToolStripMenuItem.Name = "tudoToolStripMenuItem";
            this.tudoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tudoToolStripMenuItem.Text = "Tudo";
            this.tudoToolStripMenuItem.Click += new System.EventHandler(this.tudoToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.ContextMenuStrip = this.cmsReload;
            this.btnExit.Location = new System.Drawing.Point(297, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Retornar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.ContextMenuStrip = this.cmsReload;
            this.btnSearch.Location = new System.Drawing.Point(216, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFiltroDeposito
            // 
            this.btnFiltroDeposito.ContextMenuStrip = this.cmsReload;
            this.btnFiltroDeposito.Location = new System.Drawing.Point(3, 13);
            this.btnFiltroDeposito.Name = "btnFiltroDeposito";
            this.btnFiltroDeposito.Size = new System.Drawing.Size(60, 23);
            this.btnFiltroDeposito.TabIndex = 3;
            this.btnFiltroDeposito.Text = "Depósito";
            this.btnFiltroDeposito.UseVisualStyleBackColor = true;
            this.btnFiltroDeposito.Click += new System.EventHandler(this.btnFiltroDeposito_Click);
            // 
            // panelTransferencias
            // 
            this.panelTransferencias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTransferencias.ContextMenuStrip = this.cmsReload;
            this.panelTransferencias.Controls.Add(this.btnFiltroTransferencia);
            this.panelTransferencias.Controls.Add(this.btnFiltroSaque);
            this.panelTransferencias.Controls.Add(this.lblFiltro);
            this.panelTransferencias.Controls.Add(this.btnFiltroDeposito);
            this.panelTransferencias.Location = new System.Drawing.Point(12, 221);
            this.panelTransferencias.Name = "panelTransferencias";
            this.panelTransferencias.Size = new System.Drawing.Size(198, 39);
            this.panelTransferencias.TabIndex = 4;
            // 
            // btnFiltroTransferencia
            // 
            this.btnFiltroTransferencia.ContextMenuStrip = this.cmsReload;
            this.btnFiltroTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroTransferencia.Location = new System.Drawing.Point(131, 13);
            this.btnFiltroTransferencia.Name = "btnFiltroTransferencia";
            this.btnFiltroTransferencia.Size = new System.Drawing.Size(60, 23);
            this.btnFiltroTransferencia.TabIndex = 6;
            this.btnFiltroTransferencia.Text = "Transferência";
            this.btnFiltroTransferencia.UseVisualStyleBackColor = true;
            this.btnFiltroTransferencia.Click += new System.EventHandler(this.btnFiltroTransferencia_Click);
            // 
            // btnFiltroSaque
            // 
            this.btnFiltroSaque.ContextMenuStrip = this.cmsReload;
            this.btnFiltroSaque.Location = new System.Drawing.Point(67, 13);
            this.btnFiltroSaque.Name = "btnFiltroSaque";
            this.btnFiltroSaque.Size = new System.Drawing.Size(60, 23);
            this.btnFiltroSaque.TabIndex = 5;
            this.btnFiltroSaque.Text = "Saque";
            this.btnFiltroSaque.UseVisualStyleBackColor = true;
            this.btnFiltroSaque.Click += new System.EventHandler(this.btnFiltroSaque_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.ContextMenuStrip = this.cmsReload;
            this.lblFiltro.Location = new System.Drawing.Point(69, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(53, 13);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // dGV_ConsultaTransacao
            // 
            this.dGV_ConsultaTransacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ConsultaTransacao.Location = new System.Drawing.Point(12, 12);
            this.dGV_ConsultaTransacao.Name = "dGV_ConsultaTransacao";
            this.dGV_ConsultaTransacao.Size = new System.Drawing.Size(360, 203);
            this.dGV_ConsultaTransacao.TabIndex = 5;
            // 
            // ListaTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.ContextMenuStrip = this.cmsReload;
            this.Controls.Add(this.dGV_ConsultaTransacao);
            this.Controls.Add(this.panelTransferencias);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ListaTransacoes";
            this.Text = "BankSys - Lista de Transações";
            this.Load += new System.EventHandler(this.ListaTransacoes_Load);
            this.cmsReload.ResumeLayout(false);
            this.panelTransferencias.ResumeLayout(false);
            this.panelTransferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ConsultaTransacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFiltroDeposito;
        private System.Windows.Forms.Panel panelTransferencias;
        private System.Windows.Forms.Button btnFiltroTransferencia;
        private System.Windows.Forms.Button btnFiltroSaque;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ContextMenuStrip cmsReload;
        private System.Windows.Forms.ToolStripMenuItem recarregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tudoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGV_ConsultaTransacao;
    }
}