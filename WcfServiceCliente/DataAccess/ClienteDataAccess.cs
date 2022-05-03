using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceCliente.Entidades;

namespace WcfServiceCliente.DataAccess
{
    public class ClienteDataAccess
    {
        private readonly string conexaoSQL = "Data Source=192.168.0.101,1433;Initial Catalog=dbTesteGTI;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        public bool Incluir(Cliente cliente)
        {
            try
            {

                using (SqlConnection conexaoBD = new SqlConnection(conexaoSQL))
                {
                    var q = @"insert into tblCliente
                                                (CPF,
                                                Nome,
                                                RG,
                                                DataExpedicao,
                                                OrgaoExpedicao,
                                                UF_Expedicao,
                                                DataNascimento,
                                                Sexo,
                                                EstadoCivil,

                                                CEP,
                                                Logradouro,
                                                Numero,
                                                Complemento,
                                                Bairro,
                                                Cidade,
                                                UF)
                                                values 
                                                          (@CPF,
                                                           @Nome,
                                                           @RG,
                                                           @DataExpedicao,
                                                           @OrgaoExpedicao,
                                                           @UF_Expedicao,
                                                           @DataNascimento,
                                                           @Sexo,
                                                           @EstadoCivil,
                                                           
                                                           @CEP,
                                                           @Logradouro,
                                                           @Numero,
                                                           @Complemento,
                                                           @Bairro,
                                                           @Cidade,
                                                           @UF)";

                    var result = conexaoBD.Execute(q, new
                    {
                        cliente.CPF,
                        cliente.Nome,
                        cliente.RG,
                        cliente.DataExpedicao,
                        cliente.OrgaoExpedicao,
                        cliente.UF_Expedicao,
                        cliente.DataNascimento,
                        cliente.Sexo,
                        cliente.EstadoCivil,

                        cliente.CEP,
                        cliente.Logradouro,
                        cliente.Numero,
                        cliente.Complemento,
                        cliente.Bairro,
                        cliente.Cidade,
                        cliente.UF
                    });


                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Atualizar(Cliente cliente)
        {
            try
            {

                using (SqlConnection conexaoBD = new SqlConnection(conexaoSQL))
                {
                    var q = @"update   tblCliente  set 
                                             CPF=               @CPF,
                                             Nome=              @Nome,
                                             RG=                @RG,
                                             DataExpedicao=     @DataExpedicao,
                                             OrgaoExpedicao=    @OrgaoExpedicao,
                                             UF_Expedicao=      @UF_Expedicao,
                                             DataNascimento=    @DataNascimento,
                                             Sexo=              @Sexo,
                                             EstadoCivil=       @EstadoCivil,                                              
                                             CEP=               @CEP,
                                             Logradouro=        @Logradouro,
                                             Numero=            @Numero,
                                             Complemento=       @Complemento,
                                             Bairro=            @Bairro,
                                             Cidade=            @Cidade,
                                             UF =               @UF  
                                              where Id = @Id";


                    var result = conexaoBD.Execute(q, new
                    {
                        cliente.CPF,
                        cliente.Nome,
                        cliente.RG,
                        cliente.DataExpedicao,
                        cliente.OrgaoExpedicao,
                        cliente.UF_Expedicao,
                        cliente.DataNascimento,
                        cliente.Sexo,
                        cliente.EstadoCivil,

                        cliente.CEP,
                        cliente.Logradouro,
                        cliente.Numero,
                        cliente.Complemento,
                        cliente.Bairro,
                        cliente.Cidade,
                        cliente.UF,
                        cliente.Id
                    });


                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                using (SqlConnection conexaoBD = new SqlConnection(conexaoSQL))
                {
                    var q = @"delete from  tblCliente where Id =" + id;
                    var result = conexaoBD.Execute(q);
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public List<Cliente> Listar()
        {
            var retorno = new List<Cliente>();

            try
            {
                string query = @" select * from tblCliente ";

                using (SqlConnection conexaoBD = new SqlConnection(conexaoSQL))
                {
                    retorno = conexaoBD.Query<Cliente>(query).ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return retorno;
        }


























    }
}
