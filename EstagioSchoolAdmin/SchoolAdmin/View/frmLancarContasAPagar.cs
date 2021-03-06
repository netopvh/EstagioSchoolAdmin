﻿using SchoolAdmin.Control;
using SchoolAdmin.Model;
using SchoolAdmin.Util.Validators;
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
        private DateTimePicker dtpVencimento;
        private Label label1;
        private ComboBox cbbOrigem;
        private Button btnGravar;
        private Button btnSair;
        private Button btnNovo;
        private DataGridView dgvContasAPagar;
        private Label label2;

        private ContaPagarCtr controller;
        private string strValor;
        private GroupBox gpbgrid;
        private DataGridViewTextBoxColumn Origem;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn Lançamento;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn Valor;
        private ContaAPagar instancia;

        public frmLancarContasAPagar(ContaPagarCtr ctr)
        {
            InitializeComponent();
            controller = ctr;
            CarregarComboboxs();
            InicializarControles();
        }

        private void CarregarComboboxs()
        {
            cbbOrigem.ValueMember = "Id";
            cbbOrigem.DisplayMember = "Descricao";
            cbbOrigem.DataSource = controller.GetListaOrigemConta();
        }

        private void InicializarControles()
        {
            cbbOrigem.SelectedIndex = -1;
            txtDescricao.Clear();
            dtpVencimento.Value = DateTime.Now;
            txtValor.Clear();
            InicializarDgv();
            instancia = controller.GetInstancia();
        }

        private bool ValidarDados()
        {
            bool erro = false;
            string msgErro = "";
            string titErro = "";

            StringValidator STRvalidator = new StringValidator();
            DinheiroValidator Dinvalidator = new DinheiroValidator();

            if (cbbOrigem.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, origem não informado!";
                msgErro = "Selecione a origem da conta para prosseguir com o cadastro.";
                cbbOrigem.Focus();
            }
            else if (!STRvalidator.Validar(txtDescricao.Text, 64))
            {
                erro = true;
                titErro = "Erro, descrição da conta não informada corretamente!";
                msgErro = "Informe a descrição da conta para prosseguir com o cadastro.";
                txtDescricao.Focus();
            }
            else if (dtpVencimento.Value.Date < DateTime.Today)
            {
                erro = true;
                titErro = "Erro, data de vencimento inválida!";
                msgErro = "Informe uma data de vencimento válida para prosseguir com o cadastro.";
                dtpVencimento.Focus();
            }
            else if (!Dinvalidator.Validar(txtValor.Text))
            {
                erro = true;
                titErro = "Erro, valor inválido!";
                msgErro = "Informe um valor válido para prosseguir com o cadastro.";
                txtValor.Focus();
            }

            if (erro)
            {
                MessageBox.Show(msgErro,
                                titErro,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return !erro;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancarContasAPagar));
            this.gpbForm = new System.Windows.Forms.GroupBox();
            this.gpbgrid = new System.Windows.Forms.GroupBox();
            this.dgvContasAPagar = new System.Windows.Forms.DataGridView();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lançamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOrigem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbForm.SuspendLayout();
            this.gpbgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasAPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbForm
            // 
            this.gpbForm.Controls.Add(this.gpbgrid);
            this.gpbForm.Controls.Add(this.label4);
            this.gpbForm.Controls.Add(this.txtValor);
            this.gpbForm.Controls.Add(this.label3);
            this.gpbForm.Controls.Add(this.txtDescricao);
            this.gpbForm.Controls.Add(this.dtpVencimento);
            this.gpbForm.Controls.Add(this.label1);
            this.gpbForm.Controls.Add(this.cbbOrigem);
            this.gpbForm.Controls.Add(this.label2);
            this.gpbForm.Location = new System.Drawing.Point(0, 2);
            this.gpbForm.Name = "gpbForm";
            this.gpbForm.Size = new System.Drawing.Size(596, 327);
            this.gpbForm.TabIndex = 3;
            this.gpbForm.TabStop = false;
            this.gpbForm.Text = "Lançamento de Nova Conta";
            // 
            // gpbgrid
            // 
            this.gpbgrid.Controls.Add(this.dgvContasAPagar);
            this.gpbgrid.Location = new System.Drawing.Point(6, 150);
            this.gpbgrid.Name = "gpbgrid";
            this.gpbgrid.Size = new System.Drawing.Size(579, 171);
            this.gpbgrid.TabIndex = 21;
            this.gpbgrid.TabStop = false;
            // 
            // dgvContasAPagar
            // 
            this.dgvContasAPagar.AllowUserToAddRows = false;
            this.dgvContasAPagar.AllowUserToDeleteRows = false;
            this.dgvContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasAPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origem,
            this.Descrição,
            this.Lançamento,
            this.Vencimento,
            this.Valor});
            this.dgvContasAPagar.Location = new System.Drawing.Point(8, 15);
            this.dgvContasAPagar.Name = "dgvContasAPagar";
            this.dgvContasAPagar.ReadOnly = true;
            this.dgvContasAPagar.Size = new System.Drawing.Size(565, 150);
            this.dgvContasAPagar.TabIndex = 20;
            // 
            // Origem
            // 
            this.Origem.DataPropertyName = "Origem";
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "Descrição";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 200;
            // 
            // Lançamento
            // 
            this.Lançamento.DataPropertyName = "Lançamento";
            this.Lançamento.HeaderText = "Lançamento";
            this.Lançamento.Name = "Lançamento";
            this.Lançamento.ReadOnly = true;
            this.Lançamento.Width = 70;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 70;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor :";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(274, 84);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(85, 20);
            this.txtValor.TabIndex = 10;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyUp);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(99, 53);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(260, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(99, 84);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(94, 20);
            this.dtpVencimento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vencimento :";
            // 
            // cbbOrigem
            // 
            this.cbbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrigem.FormattingEnabled = true;
            this.cbbOrigem.Location = new System.Drawing.Point(99, 20);
            this.cbbOrigem.Name = "cbbOrigem";
            this.cbbOrigem.Size = new System.Drawing.Size(260, 21);
            this.cbbOrigem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origem :";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(510, 333);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::SchoolAdmin.Properties.Resources.diskette;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(14, 335);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(120, 30);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Realizar Gravação";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::SchoolAdmin.Properties.Resources.reload;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(149, 335);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 30);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Criar Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmLancarContasAPagar
            // 
            this.ClientSize = new System.Drawing.Size(587, 369);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLancarContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Admin - Lançar Contas a Pagar";
            this.gpbForm.ResumeLayout(false);
            this.gpbForm.PerformLayout();
            this.gpbgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasAPagar)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                instancia.Descricao = txtDescricao.Text.Trim();
                instancia.Origem = (OrigemContaAPagar)cbbOrigem.SelectedItem;
                instancia.Vencimento = dtpVencimento.Value;
                instancia.Valor = GetTxtValorValue();
                
                if (controller.GravarLancamento(instancia))
                {
                    MessageBox.Show(
                        "Gravação realizada com sucesso. Todos os dados foram salvos.",
                        "Gravação realizada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    InserirNaTabela(instancia);
                   
                }
            }
        }

        private void InserirNaTabela(ContaAPagar conta)
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Origem", typeof(string));
            resultado.Columns.Add("Descrição", typeof(string));
            resultado.Columns.Add("Lançamento", typeof(DateTime));
            resultado.Columns.Add("Vencimento", typeof(DateTime));
            resultado.Columns.Add("Valor", typeof(string));
            

            DataRow linha = resultado.NewRow();

            linha["Descrição"] = conta.Descricao;
            linha["Lançamento"] = conta.DataLancamento.Date;
            linha["Vencimento"] = conta.Vencimento.Date;
            linha["Valor"] = String.Format("{0:C2}", conta.Valor);
            linha["Origem"] = conta.Origem.Descricao;

            resultado.Rows.Add(linha);

            dgvContasAPagar.DataSource = resultado;
            dgvContasAPagar.Refresh();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InicializarControles();
            InicializarDgv();
        }

        private void InicializarDgv()
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Origem", typeof(string));
            resultado.Columns.Add("Descrição", typeof(string));
            resultado.Columns.Add("Lançamento", typeof(DateTime));
            resultado.Columns.Add("Vencimento", typeof(DateTime));
            resultado.Columns.Add("Valor", typeof(Decimal));
            DataRow linha = resultado.NewRow();
            resultado.Rows.Add(linha);
            dgvContasAPagar.DataSource = resultado;
            dgvContasAPagar.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Máscara de dinheiro para txtSalario
        private Decimal GetTxtValorValue()
        {
            string strSalario = txtValor.Text.Replace("R$", "").Trim();
            return Decimal.Parse(strSalario);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtValor.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            strValor = txtValor.Text.Replace("R$", "");

            try
            {
                txtValor.Text = string.Format("{0:C}", Convert.ToDouble(strValor));
            }
            catch
            {
                txtValor.Clear();
            }
        }

        private void txtSalario_KeyUp(object sender, KeyEventArgs e)
        {
            strValor = txtValor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");

            if (strValor.Length == 0)
            {
                txtValor.Text = "0,00" + strValor;
            }
            if (strValor.Length == 1)
            {
                txtValor.Text = "0,0" + strValor;
            }
            if (strValor.Length == 2)
            {
                txtValor.Text = "0," + strValor;
            }
            else if (strValor.Length >= 3)
            {
                if (txtValor.Text.StartsWith("0,"))
                {
                    txtValor.Text = strValor.Insert(strValor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtValor.Text.Contains("00,"))
                {
                    txtValor.Text = strValor.Insert(strValor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtValor.Text = strValor.Insert(strValor.Length - 2, ",");
                }
            }

            strValor = txtValor.Text;
            txtValor.Text = string.Format("{0:C}", Convert.ToDouble(strValor));
            txtValor.Select(txtValor.Text.Length, 0);
        }
        #endregion
    }
}
