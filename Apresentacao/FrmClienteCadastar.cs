using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
//utilizando as regras de negocios
using Negocios;

namespace Apresentacao
{
    public partial class FrmClienteCadastrar : Form
    {
        //variavel da classe
        AcaoNaTela _acaoNaTela;

        //contrutor
        public FrmClienteCadastrar(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            InitializeComponent();
            //jogando o conteudo da acaoNaTela para "_acaoNaTela"
            this._acaoNaTela = acaoNaTela;

            if (acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                this.Text = "Inserir";
                textBoxCodigo.ReadOnly = true;
                textBoxCodigo.TabStop = false;
            }
            else if (acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                this.Text = "Alterar";
                RecarregarCliente(cliente);
            }
            else if (acaoNaTela.Equals(AcaoNaTela.Consultar))
            {
                this.Text = "Consultar";
                RecarregarCliente(cliente);

                //Desabilitar os Campos
                textBoxCodigo.ReadOnly = true;
                textBoxCodigo.TabStop = false;
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;
                dateDataNascimento.Enabled = false;
                radioSexoFeminino.Enabled = false;
                radioSexoMasculino.Enabled = false;
                textBoxLimiteCompra.ReadOnly = true;
                textBoxLimiteCompra.TabStop = false;
                //Botão visivel
                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";
                //foco no botão
                buttonCancelar.Focus();
            }
        }

        private void RecarregarCliente(Cliente cliente)
        {
            textBoxCodigo.Text = cliente.IdCliente.ToString();
            textBoxNome.Text = cliente.Nome;
            dateDataNascimento.Value = cliente.DataNascimento;
            #region if(verificar sexo)
            if (cliente.Sexo.Equals(true))
                radioSexoMasculino.Checked = true;
            else
                radioSexoFeminino.Checked = true;
            #endregion
            textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();
            //Desabilitando campos
            textBoxCodigo.ReadOnly = true;
            textBoxCodigo.TabStop = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //verificar se e inserçaõ ou alteração
            if (_acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBoxNome.Text;
                cliente.DataNascimento = dateDataNascimento.Value;
                //verificando o sexo pelo "Checked"
                if (radioSexoMasculino.Checked.Equals(true))
                {
                    cliente.Sexo = true;
                }
                else
                {
                    cliente.Sexo = false;
                }
                cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Inserir(cliente);

                //tentar converter paa inteiro
                //se de tudo certo é porque devolveu o codigo do cliente
                //se der errado tem a mensagem de error
                try
                {
                    int idCliente1 = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente inserido com sucecsso. Código: " + idCliente1.ToString());
                    //Essa linha fecha a tela a avisa a outra que fechou com o resultado é sim
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel Inserir!. Detalhes :" + retorno, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Essa linha fecha a tela a avisa a outra que fechou com o resultado é não
                    //ao remoover essa linha a baixo o form nao fechar, caso a rede desligue a tela fica aberta com as alterações.
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (_acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = Convert.ToInt32(textBoxCodigo.Text);
                cliente.Nome = textBoxNome.Text;
                cliente.DataNascimento = dateDataNascimento.Value;
                //verificando o sexo pelo "Checked"
                if (radioSexoMasculino.Checked.Equals(true))
                {
                    cliente.Sexo = true;
                }
                else
                {
                    cliente.Sexo = false;
                }
                cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Alterar(cliente);

                try
                {
                    int idCliente1 = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente Alterado com sucecsso. Código: " + idCliente1.ToString());
                    //Essa linha fecha a tela a avisa a outra que fechou com o resultado é sim
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel Alterar!. Detalhes :" + retorno, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Essa linha fecha a tela a avisa a outra que fechou com o resultado é não
                    //ao remoover essa linha a baixo o form nao fechar, caso a rede desligue a tela fica aberta com as alterações.
                    this.DialogResult = DialogResult.No;
                }
            }
        }

    }
}
