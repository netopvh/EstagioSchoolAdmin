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
    public partial class frmEnderecos : Form
    {
        EnderecosCtr controller;
        Endereco instancia;
        Pessoa pessoaEndereco;

        public frmEnderecos(EnderecosCtr ctr, Pessoa pessoa)
        {
            InitializeComponent();
            controller = ctr;
            pessoaEndereco = pessoa;

            CarregarCombobox();
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtRua.Clear();
            txtNumero.Value = 0;
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbEstados.SelectedIndex = -1;
            txtCep.Clear();

            txtCep.Mask = "00000 - 000";
            txtRua.Focus();
            instancia = controller.GetInstance();
        }

        private void CarregarCombobox()
        {
            cbbEstados.ValueMember = "Id";
            cbbEstados.DisplayMember = "Nome";
            cbbEstados.DataSource = controller.GetListaEstados();
        }

        private bool ValidarDados()
        {
            bool erro = false;
            string msgErro = "";
            string titErro = "";

            StringValidator STRvalidator = new StringValidator();
            CEPValidator CEPvalidator = new CEPValidator();

            if (!STRvalidator.Validar(txtRua.Text, 128))
            {
                erro = true;
                titErro = "Erro, nome da rua não foi informado corretamente!";
                msgErro = "Informe o nome da rua para prosseguir com o cadastro.";
                txtRua.Focus();
            }
            else if (txtNumero.Value < 1)
            {
                erro = true;
                titErro = "Erro, número de residência inválido!";
                msgErro = "O número da residência deve ser maior que 0.";
                txtNumero.Focus();
            }
            else if (!STRvalidator.Validar(txtBairro.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome do bairro não foi informado corretamente!";
                msgErro = "Informe o nome do bairro para prosseguir com o cadastro.";
                txtRua.Focus();
            }
            else if (!STRvalidator.Validar(txtCidade.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome da cidade não foi informado corretamente!";
                msgErro = "Informe o nome da cidade para prosseguir com o cadastro.";
                txtRua.Focus();
            }
            else if (cbbEstados.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, estado não informado!";
                msgErro = "Selecione o estado para prosseguir com o cadastro.";
                cbbEstados.Focus();
            }
            else 
            {
                Estado selecionado = (Estado) cbbEstados.SelectedItem;
                if (!CEPvalidator.Validar(txtCep.Text, selecionado.Sigla))
                {
                    erro = true;
                    titErro = "Erro, o cep não foi informado corretamente!";
                    msgErro = "Informe o cep corretamente para prosseguir com o cadastro.";
                    txtCep.Focus();
                }
                
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(ValidarDados())
            {
                instancia.Rua = txtRua.Text.Trim();
                instancia.Numero = int.Parse(txtNumero.Value.ToString());
                instancia.Complemento = txtComplemento.Text.Trim();
                instancia.Bairro = txtBairro.Text.Trim();
                instancia.Cidade = txtCidade.Text.Trim();
                instancia.Estado = (Estado)cbbEstados.SelectedItem;
                instancia.Pessoa = pessoaEndereco;

                controller.Gravar(instancia);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
