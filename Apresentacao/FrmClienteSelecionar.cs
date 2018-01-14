using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();

            //NÃO GERAR LINHAS AUTOMATICAS
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualiarGrid();
        }

        private void AtualiarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            //clienteColecao vazia vai receber os clientes do banco 
            ClienteColecao clienteColecao = clienteNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = clienteColecao;

            //atualizar apos feito a pesquisa nos dados e no visual do grid
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            //FECHANDO A JANELA
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //verificar se tem item seleionado
            if(dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado.");
                return;
            }
            //perguntar se quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza?", "Perguntar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
            if(resultado == DialogResult.No)
            {
                return;
            }
            //pegar o cliente selecionado no grid
            //Convertendo para um cliente 'as Cliente'
            //DataBoundItem dados do geid carregado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            //Instancia a regra de negocio 
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            string retorno = clienteNegocios.Excluir(clienteSelecionado);
            
            //verificar se excluio com sucesso
            //se for um número deu certo, senão é menssagem de erro
            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente Excluido com sucesso", "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualiarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir!. Detalhes :" + retorno, "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            //Instancia o formulário de cadastro
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmClienteCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualiarGrid();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //verificar se tem item seleionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado.");
                return;
            }
            //pegar o cliente selecionado no grid
            //Convertendo para um cliente 'as Cliente'
            //DataBoundItem dados do geid carregado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            //Instancia o formulário de cadastro
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(AcaoNaTela.Alterar, clienteSelecionado);
            DialogResult dialogResult = frmClienteCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualiarGrid();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //verificar se tem item seleionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado.");
                return;
            }
            //pegar o cliente selecionado no grid
            //Convertendo para um cliente 'as Cliente'
            //DataBoundItem dados do geid carregado
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            //Instancia o formulário de cadastro
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(AcaoNaTela.Consultar, clienteSelecionado);
            frmClienteCadastrar.ShowDialog();
        }
    }
}
 