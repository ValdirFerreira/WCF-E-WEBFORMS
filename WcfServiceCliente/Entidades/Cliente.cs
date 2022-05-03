using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceCliente.Entidades
{
    [DataContract]
    public class Cliente
    {

        // Dados Cliente
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CPF { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string RG { get; set; }


        [DataMember]
        public DateTime DataExpedicao { get; set; }


        [DataMember]
        public string OrgaoExpedicao { get; set; }

        [DataMember]
        public string UF_Expedicao { get; set; }


        [DataMember]
        public DateTime DataNascimento { get; set; }

        [DataMember]
        public string Sexo { get; set; }

        [DataMember]
        public string EstadoCivil { get; set; }


        // Dados Endereço cliente
        [DataMember]
        public string CEP { get; set; }
        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Complemento { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public string Cidade { get; set; }
        [DataMember]
        public string UF { get; set; }


    }
}
