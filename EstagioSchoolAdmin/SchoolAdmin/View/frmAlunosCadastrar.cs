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
    public partial class frmAlunosCadastrar : Form
    {
        AlunosCtr controller;
        private Aluno instancia;

        public frmAlunosCadastrar(AlunosCtr ctr)
        {
            InitializeComponent();
            controller = ctr;

            CarregarComboboxs();
            InicializarControles();
        }

        private void CarregarComboboxs()
        {
            Dictionary<string, char> dict = new Dictionary<string, char>();
            dict.Add("MASCULINO", 'M');
            dict.Add("FEMININO", 'F');

            cbbSexo.DisplayMember = "Key";
            cbbSexo.ValueMember = "Value";
            cbbSexo.DataSource = dict.ToList();

            cbbEstados.ValueMember = "Id";
            cbbEstados.DisplayMember = "Nome";
            cbbEstados.DataSource = controller.GetListaEstados();
        }

        private void InicializarControles()
        {
            txtNome.Clear();
            cbbSexo.SelectedIndex = -1;
            dtpNascimento.Value = DateTime.Now;
            txtMunicipio.Clear();
            cbbEstados.SelectedIndex = -1;
            instancia = controller.GetInstancia();
        }

        private bool ValidarDados()
        {
            bool erro = false;
            string msgErro = "";
            string titErro = "";

            StringValidator STRvalidator = new StringValidator();

            if (!STRvalidator.Validar(txtNome.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome do Aluno não informado corretamente!";
                msgErro = "Informe o nome do Aluno para prosseguir com o cadastro.";
                txtNome.Focus();
            }
            else if (cbbSexo.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, sexo não informado!";
                msgErro = "Selecione o sexo do Aluno para prosseguir com o cadastro.";
                cbbSexo.Focus();
            }
            else if (dtpNascimento.Value.Date >= DateTime.Today)
            {
                erro = true;
                titErro = "Erro, data de nascimento inválida!";
                msgErro = "Informe uma data de nascimento válida para prosseguir com o cadastro.";
                dtpNascimento.Focus();
            }
            else if (!STRvalidator.Validar(txtMunicipio.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome do Município não informado corretamente!";
                msgErro = "Informe o nome do Município para prosseguir com o cadastro.";
                txtNome.Focus();
            }
            else if (cbbEstados.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, estado não informado!";
                msgErro = "Selecione o estado para prosseguir com o cadastro.";
                cbbEstados.Focus();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(ValidarDados())
            {
                instancia.Nome = txtNome.Text.Trim();
                instancia.Sexo = cbbSexo.SelectedValue.ToString();
                instancia.DataNascimento = dtpNascimento.Value;
                instancia.Municipio = txtMunicipio.Text.Trim();
                instancia.Estado = (Estado)cbbEstados.SelectedItem;

                if(controller.Gravar(instancia))
                {
                    MessageBox.Show(
                        "Gravação realizada com sucesso. Todos os dados foram salvos.",
                        "Gravação realizada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    InicializarControles();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var formPesquisar = new frmAlunosPesquisar(controller))
            {
                formPesquisar.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
