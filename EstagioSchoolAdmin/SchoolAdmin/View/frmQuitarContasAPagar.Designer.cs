namespace SchoolAdmin.View
{
    partial class frmQuitarContasAPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbForm = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOrigem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.btnRegistrarBaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANÇAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbForm.SuspendLayout();
            this.gpbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbForm
            // 
            this.gpbForm.Controls.Add(this.label6);
            this.gpbForm.Controls.Add(this.label5);
            this.gpbForm.Controls.Add(this.btnFiltrar);
            this.gpbForm.Controls.Add(this.btnPesquisar);
            this.gpbForm.Controls.Add(this.dtpFim);
            this.gpbForm.Controls.Add(this.label3);
            this.gpbForm.Controls.Add(this.dtpInicio);
            this.gpbForm.Controls.Add(this.label1);
            this.gpbForm.Controls.Add(this.cbbOrigem);
            this.gpbForm.Controls.Add(this.label2);
            this.gpbForm.Location = new System.Drawing.Point(12, 12);
            this.gpbForm.Name = "gpbForm";
            this.gpbForm.Size = new System.Drawing.Size(572, 124);
            this.gpbForm.TabIndex = 2;
            this.gpbForm.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Inicio :";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(415, 85);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(128, 23);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(415, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 23);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(225, 88);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(111, 20);
            this.dtpFim.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "A";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(65, 88);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtro :";
            // 
            // cbbOrigem
            // 
            this.cbbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrigem.FormattingEnabled = true;
            this.cbbOrigem.Location = new System.Drawing.Point(23, 38);
            this.cbbOrigem.Name = "cbbOrigem";
            this.cbbOrigem.Size = new System.Drawing.Size(371, 21);
            this.cbbOrigem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origem :";
            // 
            // cbbFormaPagamento
            // 
            this.cbbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFormaPagamento.FormattingEnabled = true;
            this.cbbFormaPagamento.Location = new System.Drawing.Point(14, 179);
            this.cbbFormaPagamento.Name = "cbbFormaPagamento";
            this.cbbFormaPagamento.Size = new System.Drawing.Size(228, 21);
            this.cbbFormaPagamento.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Forma de Pagamento :";
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnRegistrarBaixa);
            this.gpbButtons.Controls.Add(this.btnSair);
            this.gpbButtons.Controls.Add(this.btnCancelar);
            this.gpbButtons.Location = new System.Drawing.Point(12, 450);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(585, 56);
            this.gpbButtons.TabIndex = 3;
            this.gpbButtons.TabStop = false;
            // 
            // btnRegistrarBaixa
            // 
            this.btnRegistrarBaixa.Location = new System.Drawing.Point(17, 19);
            this.btnRegistrarBaixa.Name = "btnRegistrarBaixa";
            this.btnRegistrarBaixa.Size = new System.Drawing.Size(123, 23);
            this.btnRegistrarBaixa.TabIndex = 15;
            this.btnRegistrarBaixa.Text = "REGISTRAR BAIXA";
            this.btnRegistrarBaixa.UseVisualStyleBackColor = true;
            this.btnRegistrarBaixa.Click += new System.EventHandler(this.btnRegisrarBaixa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(488, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Id,
            this.descricao,
            this.LANÇAMENTO,
            this.vencimento,
            this.valor,
            this.valorPago});
            this.dgvContas.Location = new System.Drawing.Point(12, 223);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.Size = new System.Drawing.Size(572, 222);
            this.dgvContas.TabIndex = 4;
            this.dgvContas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.DataPropertyName = "Selecionar";
            this.Selecionar.FalseValue = "false";
            this.Selecionar.HeaderText = "*";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ToolTipText = "SELECIONAR CONTA";
            this.Selecionar.TrueValue = "true";
            this.Selecionar.Width = 30;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "CÓDIGO";
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "CÓDIGO";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 70;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "DESCRIÇÃO";
            this.descricao.HeaderText = "DESCRIÇÃO";
            this.descricao.Name = "descricao";
            this.descricao.Width = 220;
            // 
            // LANÇAMENTO
            // 
            this.LANÇAMENTO.DataPropertyName = "LANÇAMENTO";
            this.LANÇAMENTO.HeaderText = "LANÇAMENTO";
            this.LANÇAMENTO.Name = "LANÇAMENTO";
            // 
            // vencimento
            // 
            this.vencimento.DataPropertyName = "VENCIMENTO";
            this.vencimento.HeaderText = "VENCIMENTO";
            this.vencimento.Name = "vencimento";
            this.vencimento.Width = 80;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "VALOR";
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.Width = 70;
            // 
            // valorPago
            // 
            this.valorPago.DataPropertyName = "V. PAGO";
            this.valorPago.HeaderText = "V. PAGO";
            this.valorPago.Name = "valorPago";
            this.valorPago.Width = 80;
            // 
            // frmQuitarContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 517);
            this.Controls.Add(this.dgvContas);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.cbbFormaPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpbForm);
            this.Name = "frmQuitarContasAPagar";
            this.Text = "School Admin - Quitar Contas a Pagar";
            this.gpbForm.ResumeLayout(false);
            this.gpbForm.PerformLayout();
            this.gpbButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbForm;
        private System.Windows.Forms.ComboBox cbbOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbButtons;
        private System.Windows.Forms.Button btnRegistrarBaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbbFormaPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANÇAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPago;
    }
}