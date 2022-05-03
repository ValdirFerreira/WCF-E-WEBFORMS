using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceCliente.DataAccess;
using WcfServiceCliente.Entidades;
using WcfServiceCliente.Help;

namespace WcfServiceCliente
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código e configuração ao mesmo tempo.
    public class ServiceCliente : IServiceCliente
    {

        private ClienteDataAccess _context = new ClienteDataAccess();

        public bool Atualizar(Cliente cliente, ref string mensagem)
        {
            bool resultado = true;
                    if (string.IsNullOrEmpty(cliente.CPF) || !Validacoes.IsCpf(cliente.CPF))
            {
                mensagem = "CPF Invalido.";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Nome))
            {
                mensagem = "Nome Obrigatório ";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Sexo))
            {
                mensagem = "Sexo Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.EstadoCivil))
            {
                mensagem = "Estado Civil Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.CEP))
            {
                mensagem = "CEP Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Logradouro))
            {
                mensagem = "Logradouro Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Numero))
            {
                mensagem = "Numero Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Bairro))
            {
                mensagem = "Bairro Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Cidade))
            {
                mensagem = "Cidade Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.UF))
            {
                mensagem = "UF Obrigatório";
                resultado = false;
            }
            else
            {
                //   SALVA
                mensagem = "O cliente foi atualizado com sucesso";
                resultado = true;

                _context.Atualizar(cliente);
            }
            return resultado;
        }

        public bool Excluir(int id, ref string mensagem)
        {
            bool resultado = true;
            mensagem = "O cliente foi excluido com sucesso";
            resultado = true;
            return _context.Excluir(id);
        }

        public bool Incluir(Cliente cliente, ref string mensagem)
        {
            bool resultado = true;
            if (string.IsNullOrEmpty(cliente.CPF) || !Validacoes.IsCpf(cliente.CPF))
            {
                mensagem = "CPF Invalido.";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Nome))
            {
                mensagem = "Nome Obrigatório ";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Sexo))
            {
                mensagem = "Sexo Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.EstadoCivil))
            {
                mensagem = "Estado Civil Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.CEP))
            {
                mensagem = "CEP Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Logradouro))
            {
                mensagem = "Logradouro Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Numero))
            {
                mensagem = "Numero Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Bairro))
            {
                mensagem = "Bairro Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.Cidade))
            {
                mensagem = "Cidade Obrigatório";
                resultado = false;
            }
            else if (string.IsNullOrEmpty(cliente.UF))
            {
                mensagem = "UF Obrigatório";
                resultado = false;
            }
            else
            {
                //   SALVA
                mensagem = "O cliente foi Incluido com sucesso";
                resultado = true;

                _context.Incluir(cliente);
            }
            return resultado;
        }

        public List<Cliente> Listar(int id)
        {
            return _context.Listar();
        }

    }
}
