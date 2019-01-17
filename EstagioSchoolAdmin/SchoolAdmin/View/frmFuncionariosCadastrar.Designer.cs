namespace SchoolAdmin.View
{
    partial class frmFuncionariosCadastrar
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
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbFormulario = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDemissao = new System.Windows.Forms.CheckBox();
            this.lblDemissao = new System.Windows.Forms.Label();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.dtpDemissao = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbbCargo = new System.Windows.Forms.ComboBox();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.gpbButtons.SuspendLayout();
            this.gpbFormulario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnNovo);
            this.gpbButtons.Controls.Add(this.btnExcluir);
            this.gpbButtons.Controls.Add(this.btnAlterar);
            this.gpbButtons.Controls.Add(this.btnSair);
            this.gpbButtons.Controls.Add(this.btnGravar);
            this.gpbButtons.Location = new System.Drawing.Point(12, 441);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(760, 56);
            this.gpbButtons.TabIndex = 0;
            this.gpbButtons.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(319, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(219, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(665, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(117, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gpbFormulario
            // 
            this.gpbFormulario.Controls.Add(this.groupBox1);
            this.gpbFormulario.Controls.Add(this.gpbContato);
            this.gpbFormulario.Controls.Add(this.gpbDadosPessoais);
            this.gpbFormulario.Controls.Add(this.lblObservacoes);
            this.gpbFormulario.Controls.Add(this.txtObservacoes);
            this.gpbFormulario.Location = new System.Drawing.Point(12, 12);
            this.gpbFormulario.Name = "gpbFormulario";
            this.gpbFormulario.Size = new System.Drawing.Size(760, 426);
            this.gpbFormulario.TabIndex = 1;
            this.gpbFormulario.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDemissao);
            this.groupBox1.Controls.Add(this.lblDemissao);
            this.groupBox1.Controls.Add(this.lblAdmissao);
            this.groupBox1.Controls.Add(this.dtpDemissao);
            this.groupBox1.Controls.Add(this.dtpAdmissao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.cbbCargo);
            this.groupBox1.Location = new System.Drawing.Point(8, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Contrato";
            // 
            // chkDemissao
            // 
            this.chkDemissao.AutoSize = true;
            this.chkDemissao.Location = new System.Drawing.Point(500, 33);
            this.chkDemissao.Name = "chkDemissao";
            this.chkDemissao.Size = new System.Drawing.Size(117, 17);
            this.chkDemissao.TabIndex = 2;
            this.chkDemissao.Text = "Registrar Demissão";
            this.chkDemissao.UseVisualStyleBackColor = true;
            this.chkDemissao.CheckedChanged += new System.EventHandler(this.chkDemissao_CheckedChanged);
            // 
            // lblDemissao
            // 
            this.lblDemissao.AutoSize = true;
            this.lblDemissao.Location = new System.Drawing.Point(621, 16);
            this.lblDemissao.Name = "lblDemissao";
            this.lblDemissao.Size = new System.Drawing.Size(59, 13);
            this.lblDemissao.TabIndex = 9;
            this.lblDemissao.Text = "Demissão :";
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(362, 16);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(65, 13);
            this.lblAdmissao.TabIndex = 8;
            this.lblAdmissao.Text = "Admissão * :";
            // 
            // dtpDemissao
            // 
            this.dtpDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDemissao.Location = new System.Drawing.Point(622, 32);
            this.dtpDemissao.Name = "dtpDemissao";
            this.dtpDemissao.Size = new System.Drawing.Size(100, 20);
            this.dtpDemissao.TabIndex = 12;
            // 
            // dtpAdmissao
            // 
            this.dtpAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmissao.Location = new System.Drawing.Point(364, 32);
            this.dtpAdmissao.Name = "dtpAdmissao";
            this.dtpAdmissao.Size = new System.Drawing.Size(100, 20);
            this.dtpAdmissao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salário * :";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(213, 32);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(99, 20);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            this.txtSalario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyUp);
            this.txtSalario.Leave += new System.EventHandler(this.txtSalario_Leave);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(14, 16);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(48, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo * :";
            // 
            // cbbCargo
            // 
            this.cbbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.Location = new System.Drawing.Point(11, 32);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.Size = new System.Drawing.Size(150, 21);
            this.cbbCargo.TabIndex = 9;
            // 
            // gpbContato
            // 
            this.gpbContato.Controls.Add(this.txtEmail);
            this.gpbContato.Controls.Add(this.lblEmail);
            this.gpbContato.Controls.Add(this.lblTelefone2);
            this.gpbContato.Controls.Add(this.txtTelefone2);
            this.gpbContato.Controls.Add(this.lblTelefone1);
            this.gpbContato.Controls.Add(this.txtTelefone1);
            this.gpbContato.Location = new System.Drawing.Point(8, 132);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(746, 72);
            this.gpbContato.TabIndex = 5;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(409, 34);
            this.txtEmail.MaxLength = 64;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(406, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email :";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Location = new System.Drawing.Point(210, 19);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(70, 13);
            this.lblTelefone2.TabIndex = 16;
            this.lblTelefone2.Text = "Telefone (2) :";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(211, 35);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone2.TabIndex = 7;
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(8, 19);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(62, 13);
            this.lblTelefone1.TabIndex = 14;
            this.lblTelefone1.Text = "Telefone * :";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(9, 35);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone1.TabIndex = 6;
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.lblEndereco);
            this.gpbDadosPessoais.Controls.Add(this.btnEndereco);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblRG);
            this.gpbDadosPessoais.Controls.Add(this.lblSexo);
            this.gpbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.txtCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtRG);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.cbbSexo);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Location = new System.Drawing.Point(8, 8);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(746, 118);
            this.gpbDadosPessoais.TabIndex = 4;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(503, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(66, 13);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço * :";
            // 
            // btnEndereco
            // 
            this.btnEndereco.Location = new System.Drawing.Point(504, 71);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(203, 23);
            this.btnEndereco.TabIndex = 14;
            this.btnEndereco.Text = "CADASTRAR ENDEREÇO";
            this.btnEndereco.UseVisualStyleBackColor = true;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(236, 57);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 13);
            this.lblCPF.TabIndex = 11;
            this.lblCPF.Text = "CPF * :";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(8, 57);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(36, 13);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG * :";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(502, 17);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(44, 13);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo * :";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(350, 18);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(117, 13);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Data de Nascimento * :";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(238, 73);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(200, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(9, 73);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(200, 20);
            this.txtRG.TabIndex = 4;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(352, 34);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(108, 20);
            this.dtpDataNascimento.TabIndex = 2;
            // 
            // cbbSexo
            // 
            this.cbbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Location = new System.Drawing.Point(504, 33);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbbSexo.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome * :";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(9, 34);
            this.txtNome.MaxLength = 64;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(14, 318);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(76, 13);
            this.lblObservacoes.TabIndex = 3;
            this.lblObservacoes.Text = "Observações :";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(16, 334);
            this.txtObservacoes.MaxLength = 512;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(724, 75);
            this.txtObservacoes.TabIndex = 13;
            // 
            // frmFuncionariosCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 506);
            this.Controls.Add(this.gpbFormulario);
            this.Controls.Add(this.gpbButtons);
            this.Name = "frmFuncionariosCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Admin - Cadastro de Funcionários";
            this.gpbButtons.ResumeLayout(false);
            this.gpbFormulario.ResumeLayout(false);
            this.gpbFormulario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbButtons;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbFormulario;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDemissao;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.DateTimePicker dtpDemissao;
        private System.Windows.Forms.DateTimePicker dtpAdmissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbbCargo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox chkDemissao;
        private System.Windows.Forms.TextBox txtEmail;
    }
}