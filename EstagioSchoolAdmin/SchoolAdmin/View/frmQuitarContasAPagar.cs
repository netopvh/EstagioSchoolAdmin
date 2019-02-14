using SchoolAdmin.Control;
using SchoolAdmin.Model;
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
    public partial class frmQuitarContasAPagar : Form
    {
        private ContaPagarCtr controller;

        public frmQuitarContasAPagar(ContaPagarCtr ctr)
        {
            InitializeComponent();

            controller = ctr;
            CarregarComboboxs();
            EstadoContaNaoSelecionada();
        }
        
        private void EstadoContaNaoSelecionada()
        {
            cbbFormaPagamento.Enabled = false;
            btnRegistrarBaixa.Enabled = false;
        }

        private void CarregarComboboxs()
        {
            cbbOrigem.ValueMember = "Id";
            cbbOrigem.DisplayMember = "Descricao";
            cbbOrigem.DataSource = controller.GetListaOrigemConta();

            cbbFormaPagamento.ValueMember = "Id";
            cbbFormaPagamento.DisplayMember = "Descricao";
            cbbFormaPagamento.DataSource = controller.GetListaFormasPagamento();
        }

        private void atualizarGridView(DataTable dt)
        {
            dgvContas.DataSource = dt;
            dgvContas.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            OrigemContaAPagar origem = (OrigemContaAPagar) cbbOrigem.SelectedItem;
            
            DataTable resultado = controller.PesquisarContas(origem);
            if(resultado.Rows.Count < 1)
            {
                MessageBox.Show("Não foi encontrado nenhuma como resultado",
                    "School - Nenhum Resultado Encontrado.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizarGridView(resultado);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            OrigemContaAPagar origem = (OrigemContaAPagar)cbbOrigem.SelectedItem;
            DateTime inicio = dtpInicio.Value;
            DateTime fim = dtpFim.Value;
            
            if(fim.Date != DateTime.Today && inicio.Date > fim.Date)
            {
                MessageBox.Show("O período de vencimento selecionado é inválido, o fim do período é anterior ao inicio",
                    "School - Data selecionada inválida.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable resultado = controller.FiltrarContasPorDataVencimento(origem, inicio, fim);
            if (resultado.Rows.Count < 1)
            {
                MessageBox.Show("Não foi encontrada nenhuma conta como resultado.",
                    "School - Nenhum Resultado Encontrado.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizarGridView(resultado);
        }

        private void btnRegisrarBaixa_Click(object sender, EventArgs e)
        {

        }

        private void dgvContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch
            {
            }
        }

        private void dgvContas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvContas.Columns["Selecionar"].Index)
            {
                try
                {
                    DataGridViewRow row = dgvContas.Rows[e.RowIndex];
                    var ckbox = (DataGridViewCheckBoxCell)dgvContas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    bool bChecked = (null != ckbox && null != ckbox.Value && true == (bool)ckbox.Value);
                    if (!bChecked)
                    {
                        row.Cells["Selecionar"].Value = true;

                    }
                    else
                    {
                        row.Cells["Selecionar"].Value = false;

                    }


                    if ((bool)ckbox.Value)
                    {
                        string conta, vencimento, valor;

                        string selecionado = dgvContas.Rows[e.RowIndex].Cells[1].Value.ToString();
                        conta = dgvContas.Rows[e.RowIndex].Cells[2].Value.ToString();
                        vencimento = dgvContas.Rows[e.RowIndex].Cells[4].Value.ToString();
                        valor = dgvContas.Rows[e.RowIndex].Cells[5].Value.ToString();

                        int contaSelecionada = int.Parse(selecionado);

                        String mensagem = String
                                    .Format("\nCONTA: '{0}' \nVENCIMENTO: {1} \nVALOR: {2} ",
                                    conta, vencimento, valor);

                        MessageBox.Show(mensagem, "CONTA SELECIONADA", MessageBoxButtons.OK);
                    }

                    
                }
                catch
                {

                }


            }
        }
    }
}
