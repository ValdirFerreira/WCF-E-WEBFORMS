using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceCliente.Entidades;

namespace WcfServiceCliente
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServiceCliente
    {
        [OperationContract]
        List<Cliente> Listar(int id);

        [OperationContract]
        bool Incluir(Cliente cliente, ref string mensagem);

        [OperationContract]
        bool Atualizar(Cliente cliente, ref string mensagem);

        [OperationContract]
        bool Excluir(int id, ref string mensagem);

        // TODO: Adicione suas operações de serviço aqui
    }


}
