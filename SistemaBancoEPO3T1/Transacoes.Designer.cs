namespace SistemaBancoEPO3T1 {
    partial class Transacoes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transacoes));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmsHelp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsHelp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.ContextMenuStrip = this.cmsHelp;
            this.btnRegistrar.Location = new System.Drawing.Point(173, 86);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmsHelp
            // 
            this.cmsHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.cmsHelp.Name = "cmsHelp";
            this.cmsHelp.Size = new System.Drawing.Size(106, 26);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.ContextMenuStrip = this.cmsHelp;
            this.btnExit.Location = new System.Drawing.Point(12, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Retornar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.ContextMenuStrip = this.cmsHelp;
            this.btnClear.Location = new System.Drawing.Point(93, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.ContextMenuStrip = this.cmsHelp;
            this.lblOrigem.Location = new System.Drawing.Point(3, 30);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(43, 13);
            this.lblOrigem.TabIndex = 4;
            this.lblOrigem.Text = "Origem:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.ContextMenuStrip = this.cmsHelp;
            this.lblDestino.Location = new System.Drawing.Point(0, 4);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.ContextMenuStrip = this.cmsHelp;
            this.lblValue.Location = new System.Drawing.Point(12, 56);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "Valor:";
            // 
            // txtOrigem
            // 
            this.txtOrigem.ContextMenuStrip = this.cmsHelp;
            this.txtOrigem.Location = new System.Drawing.Point(46, 27);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(199, 20);
            this.txtOrigem.TabIndex = 7;
            // 
            // txtDestino
            // 
            this.txtDestino.ContextMenuStrip = this.cmsHelp;
            this.txtDestino.Location = new System.Drawing.Point(46, 1);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(199, 20);
            this.txtDestino.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.ContextMenuStrip = this.cmsHelp;
            this.txtValor.Location = new System.Drawing.Point(46, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(199, 20);
            this.txtValor.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ContextMenuStrip = this.cmsHelp;
            this.panel1.Controls.Add(this.lblDestino);
            this.panel1.Controls.Add(this.txtOrigem);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.lblOrigem);
            this.panel1.Controls.Add(this.lblValue);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 80);
            this.panel1.TabIndex = 10;
            // 
            // Transacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 114);
            this.ContextMenuStrip = this.cmsHelp;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(276, 152);
            this.MinimumSize = new System.Drawing.Size(276, 152);
            this.Name = "Transacoes";
            this.Text = "BankSys - Transações";
            this.cmsHelp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsHelp;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}