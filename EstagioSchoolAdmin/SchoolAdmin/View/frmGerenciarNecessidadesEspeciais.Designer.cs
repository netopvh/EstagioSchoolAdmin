﻿namespace SchoolAdmin.View
{
    partial class frmGerenciarNecessidadesEspeciais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarNecessidadesEspeciais));
            this.gpbForm = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbGrid = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNecessidades = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbForm.SuspendLayout();
            this.gpbGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNecessidades)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbForm
            // 
            this.gpbForm.Controls.Add(this.txtDescricao);
            this.gpbForm.Controls.Add(this.label1);
            this.gpbForm.Controls.Add(this.gpbGrid);
            this.gpbForm.Location = new System.Drawing.Point(-2, 7);
            this.gpbForm.Name = "gpbForm";
            this.gpbForm.Size = new System.Drawing.Size(521, 351);
            this.gpbForm.TabIndex = 6;
            this.gpbForm.TabStop = false;
            this.gpbForm.Text = "Gerenciar Necessidades Especiais";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(101, 298);
            this.txtDescricao.MaxLength = 64;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(337, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição :";
            // 
            // gpbGrid
            // 
            this.gpbGrid.Controls.Add(this.btnPesquisar);
            this.gpbGrid.Controls.Add(this.txtPesquisar);
            this.gpbGrid.Controls.Add(this.label2);
            this.gpbGrid.Controls.Add(this.dgvNecessidades);
            this.gpbGrid.Location = new System.Drawing.Point(12, 28);
            this.gpbGrid.Name = "gpbGrid";
            this.gpbGrid.Size = new System.Drawing.Size(492, 243);
            this.gpbGrid.TabIndex = 2;
            this.gpbGrid.TabStop = false;
            this.gpbGrid.Text = "Pesquisar Necessidade";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::SchoolAdmin.Properties.Resources.find;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(376, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 30);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(82, 22);
            this.txtPesquisar.MaxLength = 64;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(270, 20);
            this.txtPesquisar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição :";
            // 
            // dgvNecessidades
            // 
            this.dgvNecessidades.AllowUserToAddRows = false;
            this.dgvNecessidades.AllowUserToDeleteRows = false;
            this.dgvNecessidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNecessidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descrição});
            this.dgvNecessidades.Location = new System.Drawing.Point(6, 53);
            this.dgvNecessidades.Name = "dgvNecessidades";
            this.dgvNecessidades.ReadOnly = true;
            this.dgvNecessidades.Size = new System.Drawing.Size(480, 183);
            this.dgvNecessidades.TabIndex = 1;
            this.dgvNecessidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "Descrição";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 385;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(427, 366);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SchoolAdmin.Properties.Resources.close_icon;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(192, 366);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 30);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::SchoolAdmin.Properties.Resources.reload;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(101, 366);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(74, 30);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::SchoolAdmin.Properties.Resources.diskette;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(10, 366);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 25;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmGerenciarNecessidadesEspeciais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 402);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gpbForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarNecessidadesEspeciais";
            this.Text = "School Admin - Gerenciar Necessidades Especiais";
            this.gpbForm.ResumeLayout(false);
            this.gpbForm.PerformLayout();
            this.gpbGrid.ResumeLayout(false);
            this.gpbGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNecessidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbForm;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbGrid;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNecessidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
    }
}