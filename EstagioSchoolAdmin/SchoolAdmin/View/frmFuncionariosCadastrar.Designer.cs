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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbFormulario = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAdmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDemissao = new System.Windows.Forms.DateTimePicker();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.lblDemissao = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbButtons.SuspendLayout();
            this.gpbFormulario.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnNovo);
            this.gpbButtons.Controls.Add(this.btnExcluir);
            this.gpbButtons.Controls.Add(this.btnAlter);
            this.gpbButtons.Controls.Add(this.btnSair);
            this.gpbButtons.Controls.Add(this.btnGravar);
            this.gpbButtons.Location = new System.Drawing.Point(12, 493);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(760, 56);
            this.gpbButtons.TabIndex = 0;
            this.gpbButtons.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(117, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(665, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
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
            this.gpbFormulario.Size = new System.Drawing.Size(760, 475);
            this.gpbFormulario.TabIndex = 1;
            this.gpbFormulario.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(16, 334);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(724, 126);
            this.txtObservacoes.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 20);
            this.txtNome.TabIndex = 3;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome :";
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Location = new System.Drawing.Point(504, 33);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbbSexo.TabIndex = 2;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(352, 34);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(108, 20);
            this.dtpDataNascimento.TabIndex = 5;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(9, 73);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(200, 20);
            this.txtRG.TabIndex = 6;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(238, 73);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(200, 20);
            this.txtCPF.TabIndex = 7;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(350, 18);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(110, 13);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Data de Nascimento :";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(502, 17);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 13);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(8, 57);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 13);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG :";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(236, 57);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 13);
            this.lblCPF.TabIndex = 11;
            this.lblCPF.Text = "CPF :";
            // 
            // btnEndereco
            // 
            this.btnEndereco.Location = new System.Drawing.Point(504, 71);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(203, 23);
            this.btnEndereco.TabIndex = 5;
            this.btnEndereco.Text = "CADASTRAR ENDEREÇO";
            this.btnEndereco.UseVisualStyleBackColor = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(503, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 13);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço :";
            // 
            // gpbContato
            // 
            this.gpbContato.Controls.Add(this.lblEmail);
            this.gpbContato.Controls.Add(this.txtEmail);
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
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(8, 19);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone1.TabIndex = 14;
            this.lblTelefone1.Text = "Telefone :";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(9, 35);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone1.TabIndex = 13;
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
            this.txtTelefone2.TabIndex = 15;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(407, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(746, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Contrato";
            // 
            // cbbCargo
            // 
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.Location = new System.Drawing.Point(11, 32);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.Size = new System.Drawing.Size(150, 21);
            this.cbbCargo.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(14, 16);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(213, 32);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(99, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salário :";
            // 
            // dtpAdmissao
            // 
            this.dtpAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmissao.Location = new System.Drawing.Point(407, 32);
            this.dtpAdmissao.Name = "dtpAdmissao";
            this.dtpAdmissao.Size = new System.Drawing.Size(100, 20);
            this.dtpAdmissao.TabIndex = 6;
            // 
            // dtpDemissao
            // 
            this.dtpDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDemissao.Location = new System.Drawing.Point(594, 33);
            this.dtpDemissao.Name = "dtpDemissao";
            this.dtpDemissao.Size = new System.Drawing.Size(100, 20);
            this.dtpDemissao.TabIndex = 7;
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(405, 16);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(58, 13);
            this.lblAdmissao.TabIndex = 8;
            this.lblAdmissao.Text = "Admissão :";
            // 
            // lblDemissao
            // 
            this.lblDemissao.AutoSize = true;
            this.lblDemissao.Location = new System.Drawing.Point(593, 17);
            this.lblDemissao.Name = "lblDemissao";
            this.lblDemissao.Size = new System.Drawing.Size(59, 13);
            this.lblDemissao.TabIndex = 9;
            this.lblDemissao.Text = "Demissão :";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(219, 19);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 2;
            this.btnAlter.Text = "ALTERAR";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(319, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmFuncionariosCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbFormulario);
            this.Controls.Add(this.gpbButtons);
            this.Name = "frmFuncionariosCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Admin - Cadastro de Funcionários";
            this.gpbButtons.ResumeLayout(false);
            this.gpbFormulario.ResumeLayout(false);
            this.gpbFormulario.PerformLayout();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox txtEmail;
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
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
    }
}