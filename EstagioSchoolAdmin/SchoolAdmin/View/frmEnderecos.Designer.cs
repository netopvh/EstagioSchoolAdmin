namespace SchoolAdmin.View
{
    partial class frmEnderecos
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
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbEnderecoMain = new System.Windows.Forms.GroupBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbEnderecoMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.gpbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(20, 13);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(37, 13);
            this.lblRua.TabIndex = 3;
            this.lblRua.Text = "Rua *:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(454, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número *:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(17, 29);
            this.txtRua.MaxLength = 128;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(395, 20);
            this.txtRua.TabIndex = 2;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(20, 56);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento.TabIndex = 5;
            this.lblComplemento.Text = "Complemento :";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(17, 72);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(395, 20);
            this.txtComplemento.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(454, 56);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro *:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(451, 72);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(172, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(20, 99);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade *:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(17, 115);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(223, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CEP *:";
            // 
            // gpbEnderecoMain
            // 
            this.gpbEnderecoMain.Controls.Add(this.txtCep);
            this.gpbEnderecoMain.Controls.Add(this.txtNumero);
            this.gpbEnderecoMain.Controls.Add(this.label1);
            this.gpbEnderecoMain.Controls.Add(this.cbbEstados);
            this.gpbEnderecoMain.Controls.Add(this.label3);
            this.gpbEnderecoMain.Controls.Add(this.txtCidade);
            this.gpbEnderecoMain.Controls.Add(this.lblCidade);
            this.gpbEnderecoMain.Controls.Add(this.txtBairro);
            this.gpbEnderecoMain.Controls.Add(this.lblBairro);
            this.gpbEnderecoMain.Controls.Add(this.txtComplemento);
            this.gpbEnderecoMain.Controls.Add(this.lblComplemento);
            this.gpbEnderecoMain.Controls.Add(this.txtRua);
            this.gpbEnderecoMain.Controls.Add(this.lblNumero);
            this.gpbEnderecoMain.Controls.Add(this.lblRua);
            this.gpbEnderecoMain.Location = new System.Drawing.Point(7, 8);
            this.gpbEnderecoMain.Name = "gpbEnderecoMain";
            this.gpbEnderecoMain.Size = new System.Drawing.Size(640, 175);
            this.gpbEnderecoMain.TabIndex = 4;
            this.gpbEnderecoMain.TabStop = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(451, 116);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(451, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 20);
            this.txtNumero.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estado *:";
            // 
            // cbbEstados
            // 
            this.cbbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Location = new System.Drawing.Point(260, 115);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(152, 21);
            this.cbbEstados.TabIndex = 5;
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnSair);
            this.gpbButtons.Controls.Add(this.btnGravar);
            this.gpbButtons.Location = new System.Drawing.Point(7, 189);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(640, 55);
            this.gpbButtons.TabIndex = 15;
            this.gpbButtons.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(548, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(13, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 259);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.gpbEnderecoMain);
            this.Name = "frmEnderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Endereço";
            this.gpbEnderecoMain.ResumeLayout(false);
            this.gpbEnderecoMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.gpbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbEnderecoMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.GroupBox gpbButtons;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.NumericUpDown txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCep;
    }
}