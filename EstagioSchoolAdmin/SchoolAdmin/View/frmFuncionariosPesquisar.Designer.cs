namespace SchoolAdmin.View
{
    partial class frmFuncionariosPesquisar
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(12, 20);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(114, 13);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome do Funcionário :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(390, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(528, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(144, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = " PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(5, 60);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(674, 289);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // frmFuncionariosPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Name = "frmFuncionariosPesquisar";
            this.Text = "School Admin - Pesquisar Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
    }
}