using SchoolAdmin.Control;
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
        private GroupBox gpbButtons;
        private Button btnGravar;
        private Button btnSair;
        private Button btnNovo;
        private DataGridView dgvContasAPagar;
        private Label label2;

        private ContaPagarCtr controller;
        private string strValor;
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
            cbbOrigem.DataSource = controller.GetListaCargos();
        }

        private void InicializarControles()
        {
            cbbOrigem.SelectedIndex = -1;
            txtDescricao.Clear();
            dtpVencimento.Value = DateTime.Now;
            txtValor.Clear();


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
            this.gpbForm = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOrigem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvContasAPagar = new System.Windows.Forms.DataGridView();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lançamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gpbForm.Controls.Add(this.dtpVencimento);
            this.gpbForm.Controls.Add(this.label1);
            this.gpbForm.Controls.Add(this.cbbOrigem);
            this.gpbForm.Controls.Add(this.label2);
            this.gpbForm.Location = new System.Drawing.Point(12, 8);
            this.gpbForm.Name = "gpbForm";
            this.gpbForm.Size = new System.Drawing.Size(437, 164);
            this.gpbForm.TabIndex = 3;
            this.gpbForm.TabStop = false;
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
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(171, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyUp);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(24, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(277, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(24, 127);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(116, 20);
            this.dtpVencimento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vencimento :";
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
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnGravar);
            this.gpbButtons.Controls.Add(this.btnSair);
            this.gpbButtons.Controls.Add(this.btnNovo);
            this.gpbButtons.Location = new System.Drawing.Point(12, 370);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(437, 56);
            this.gpbButtons.TabIndex = 4;
            this.gpbButtons.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(105, 19);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.dgvContasAPagar.Location = new System.Drawing.Point(12, 193);
            this.dgvContasAPagar.Name = "dgvContasAPagar";
            this.dgvContasAPagar.ReadOnly = true;
            this.dgvContasAPagar.Size = new System.Drawing.Size(437, 150);
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
            // frmLancarContasAPagar
            // 
            this.ClientSize = new System.Drawing.Size(462, 434);
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
            resultado.Columns.Add("Valor", typeof(Decimal));
            

            DataRow linha = resultado.NewRow();

            linha["Descrição"] = conta.Descricao;
            linha["Lançamento"] = conta.DataLancamento.Date;
            linha["Vencimento"] = conta.Vencimento.Date;
            linha["Valor"] = conta.Valor;
            linha["Origem"] = conta.Origem.Descricao;

            resultado.Rows.Add(linha);

            dgvContasAPagar.DataSource = resultado;
            dgvContasAPagar.Refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

            InicializarControles();
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
