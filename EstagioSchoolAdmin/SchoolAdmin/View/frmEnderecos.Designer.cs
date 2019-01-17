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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gpbEnderecoMain = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpbEnderecoMain.SuspendLayout();
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
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(451, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(57, 20);
            this.txtNumero.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 20);
            this.textBox1.TabIndex = 4;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(451, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 6;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(453, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // gpbEnderecoMain
            // 
            this.gpbEnderecoMain.Controls.Add(this.label1);
            this.gpbEnderecoMain.Controls.Add(this.comboBox1);
            this.gpbEnderecoMain.Controls.Add(this.textBox5);
            this.gpbEnderecoMain.Controls.Add(this.label3);
            this.gpbEnderecoMain.Controls.Add(this.txtCidade);
            this.gpbEnderecoMain.Controls.Add(this.lblCidade);
            this.gpbEnderecoMain.Controls.Add(this.textBox2);
            this.gpbEnderecoMain.Controls.Add(this.lblBairro);
            this.gpbEnderecoMain.Controls.Add(this.textBox1);
            this.gpbEnderecoMain.Controls.Add(this.lblComplemento);
            this.gpbEnderecoMain.Controls.Add(this.txtRua);
            this.gpbEnderecoMain.Controls.Add(this.lblNumero);
            this.gpbEnderecoMain.Controls.Add(this.txtNumero);
            this.gpbEnderecoMain.Controls.Add(this.lblRua);
            this.gpbEnderecoMain.Location = new System.Drawing.Point(7, 8);
            this.gpbEnderecoMain.Name = "gpbEnderecoMain";
            this.gpbEnderecoMain.Size = new System.Drawing.Size(640, 175);
            this.gpbEnderecoMain.TabIndex = 4;
            this.gpbEnderecoMain.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 5;
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
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.button2);
            this.gpbButtons.Controls.Add(this.button1);
            this.gpbButtons.Location = new System.Drawing.Point(7, 189);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(640, 55);
            this.gpbButtons.TabIndex = 15;
            this.gpbButtons.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "GRAVAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 259);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.gpbEnderecoMain);
            this.Name = "frmEnderecos";
            this.Text = "Endereço";
            this.gpbEnderecoMain.ResumeLayout(false);
            this.gpbEnderecoMain.PerformLayout();
            this.gpbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gpbEnderecoMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gpbButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}