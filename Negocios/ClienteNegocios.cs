using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//usando a classe AcessoBancoDados e ObjetoTransferencia
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        //INSTANCIAR
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente)
        {
            try
            {
                //Limpando a Colletcion
                acessoDadosSqlServer.LimparParametros();
                //ADD NA COLLECTION
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
                //acessando o banco de dados, passamos o commadTypr como StoredProdedure e passamos o nome da Procedure que esta no banco de dados com "uspClienteInserir"
                string idCliente = acessoDadosSqlServer.ExecutarManipular(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                //Limpando a Colletcion
                acessoDadosSqlServer.LimparParametros();
                //ADD NA COLLECTION
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
                //acessando o banco de dados, passamos o commadTypr como StoredProdedure e passamos o nome da Procedure que esta no banco de dados com "uspClienteAlterar"
                string idCliente = acessoDadosSqlServer.ExecutarManipular(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                //Limpando a Colletcion
                acessoDadosSqlServer.LimparParametros();
                //ADD NA COLLECTION
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                //acessando o banco de dados, passamos o commadType como StoredProdedure e passamos o nome da Procedure que esta no banco de dados com "uspClienteExcluir"
                string idCliente = acessoDadosSqlServer.ExecutarManipular(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
                //manipular o commandType por texto
                //string idCliente = acessoDadosSqlServer.ExecutarManipular(CommandType.Text, "Delete from tblCLiente where IdCliente = @IdCliente").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public ClienteColecao ConsultarPorNome(string nome)
        {
            try
            {
                //instancia
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                //DataTable
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");
                //percorer o dataTable
                //cada linha um cliente(.ROWS)
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //CLIENTE VAZIO
                    Cliente cliente = new Cliente();
                    //PREENCHENDO O CLIENTE
                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);
                    //add na coleção
                    clienteColecao.Add(cliente);
                }

                //retornando um coleçao de clientess
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar por nome. Detalhes :" + ex.Message);
            }
        }

        public ClienteColecao ConsultarPorId(int idCliente)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IdClinte", idCliente);

                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorId");

                foreach (DataRow dataRowLinha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(dataRowLinha["IdCliente"]);
                    cliente.Nome = Convert.ToString(dataRowLinha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(dataRowLinha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(dataRowLinha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(dataRowLinha["LimiteCompra"]);
                    //add na Coleção de cliente
                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                //Exeção para ir até a tela
                throw new Exception("Não foi possivel consultar por código. Detalhes :" + ex.Message);
            }


        }
    }
}
