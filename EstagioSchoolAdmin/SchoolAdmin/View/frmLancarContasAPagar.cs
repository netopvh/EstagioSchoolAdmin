using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAdmin.View
{
    public partial class frmLancarContasAPagar : Form
    {
        private GroupBox gpbForm;
        private Label label4;
        private MaskedTextBox txtValor;
        private Label label3;
        private TextBox txtDescricao;
        private DateTimePicker dtpInicio;
        private Label label1;
        private ComboBox cbbOrigem;
        private GroupBox gpbButtons;
        private Button btnGravar;
        private Button btnSair;
        private Button btnCancelar;
        private DataGridView dgvContasAPagar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn vencimento;
        private DataGridViewTextBoxColumn valor;
        private Label label2;

        public frmLancarContasAPagar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.gpbForm = new System.Windows.Forms.GroupBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOrigem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvContasAPagar = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbForm.SuspendLayout();
            this.gpbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasAPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbForm
            // 
            this.gpbForm.Controls.Add(this.label4);
            this.gpbForm.Controls.Add(this.txtValor);
            this.gpbForm.Controls.Add(this.label3);
            this.gpbForm.Controls.Add(this.txtDescricao);
            this.gpbForm.Controls.Add(this.dtpInicio);
            this.gpbForm.Controls.Add(this.label1);
            this.gpbForm.Controls.Add(this.cbbOrigem);
            this.gpbForm.Controls.Add(this.label2);
            this.gpbForm.Location = new System.Drawing.Point(12, 8);
            this.gpbForm.Name = "gpbForm";
            this.gpbForm.Size = new System.Drawing.Size(437, 164);
            this.gpbForm.TabIndex = 3;
            this.gpbForm.TabStop = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(24, 127);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(116, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data de Nascimento :";
            // 
            // cbbOrigem
            // 
            this.cbbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrigem.FormattingEnabled = true;
            this.cbbOrigem.Location = new System.Drawing.Point(23, 31);
            this.cbbOrigem.Name = "cbbOrigem";
            this.cbbOrigem.Size = new System.Drawing.Size(278, 21);
            this.cbbOrigem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origem :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(24, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(277, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição :";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(171, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor :";
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnGravar);
            this.gpbButtons.Controls.Add(this.btnSair);
            this.gpbButtons.Controls.Add(this.btnCancelar);
            this.gpbButtons.Location = new System.Drawing.Point(12, 370);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(437, 56);
            this.gpbButtons.TabIndex = 4;
            this.gpbButtons.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(17, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(117, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvContasAPagar
            // 
            this.dgvContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasAPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.vencimento,
            this.valor});
            this.dgvContasAPagar.Location = new System.Drawing.Point(12, 193);
            this.dgvContasAPagar.Name = "dgvContasAPagar";
            this.dgvContasAPagar.Size = new System.Drawing.Size(437, 150);
            this.dgvContasAPagar.TabIndex = 20;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 50;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "DESCRIÇÃO";
            this.descricao.Name = "descricao";
            this.descricao.Width = 200;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "VENCIMENTO";
            this.vencimento.Name = "vencimento";
            this.vencimento.Width = 80;
            // 
            // valor
            // 
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.Width = 60;
            // 
            // frmLancarContasAPagar
            // 
            this.ClientSize = new System.Drawing.Size(466, 434);
            this.Controls.Add(this.dgvContasAPagar);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.gpbForm);
            this.Name = "frmLancarContasAPagar";
            this.Text = "School Admin - Lançar Contas a Pagar";
            this.gpbForm.ResumeLayout(false);
            this.gpbForm.PerformLayout();
            this.gpbButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasAPagar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
