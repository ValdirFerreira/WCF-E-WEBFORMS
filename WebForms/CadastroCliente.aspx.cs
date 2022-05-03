using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.ServiceClientes;

namespace WebForms
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validaCPF.Visible = false;
            formCadastrocampos.Visible = false;
            formListaCliente.Visible = true;
            preencheGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var clienteService = new ServiceClientes.ServiceClienteClient();

            var mensagem = string.Empty;


            if (!ValidaCampos())
            {
                return;
            }

            clienteService.Incluir(new ServiceClientes.Cliente
            {
                CPF = txtCPF.Text,
                Bairro = txtBairro.Text,
                CEP = txtCEP.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComplemento.Text,
                DataExpedicao = Convert.ToDateTime(txtDataExpedicao.Text),
                DataNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                EstadoCivil = DropEstadoCivil.Text,
                Logradouro = txtRua.Text,
                Nome = txtNome.Text,
                Numero = txtNumero.Text,
                OrgaoExpedicao = txtOrgaoExpedicao.Text,
                RG = txtRG.Text,
                Sexo = DropSexo.Text,
                UF = DropUF.Text,
                UF_Expedicao = dropUFExpedicao.Text,

            }, ref mensagem);

        }

        private bool ValidaCampos()
        {
            var validSalvar = true;

            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                validaCPF.Visible = true;
                validSalvar = false;
            }


            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                validaNome.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtDataNascimento.Text))
            {
                validaDataNascimento.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(DropSexo.Text))
            {
                validaSexo.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(DropEstadoCivil.Text))
            {
                validaEstadoCivil.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                validaNome.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                validaCEP.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                validaRua.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                validaNumero.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                validaBairro.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                validaCidade.Visible = true;
                validSalvar = false;
            }

            if (string.IsNullOrWhiteSpace(DropUF.Text))
            {
                validaUF.Visible = true;
                validSalvar = false;
            }


            return validSalvar;
        }

        private void LimpaTela()
        {
            txtCPF.Text = "";
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtDataExpedicao.Text = "";
            txtDataNascimento.Text = "";

            txtRua.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtOrgaoExpedicao.Text = "";
            txtRG.Text = "";
            //DropSexo.Text = "";
            //DropUF.Text = "";
            //dropUFExpedicao.Text = "";
        }

        protected void btnTelaCadastro_Click(object sender, EventArgs e)
        {
            formCadastrocampos.Visible = true;
            LimpaTela();
        }

        protected void btnTelaListagem_Click(object sender, EventArgs e)
        {
            formCadastrocampos.Visible = false;

            preencheGrid();
        }

        public void preencheGrid()
        {
            var clienteService = new ServiceClientes.ServiceClienteClient();
            var listaClientes = clienteService.Listar(1);
            DataTable tabela = ConvertTo<Cliente>(listaClientes);


            ClienteGridView.DataSource = null;
            ClienteGridView.DataSource = tabela;
            ClienteGridView.DataBind();
        }


        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                table.Rows.Add(row);
            }
            return table;
        }
        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            return table;
        }

        protected void ClienteGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void ClienteGridView_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            ClienteGridView.EditIndex = e.NewEditIndex;
            preencheGrid();
        }

        protected void ClienteGridView_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Obtem cada valor único do DataKeyNames
            int id = Convert.ToInt32(ClienteGridView.DataKeys[e.RowIndex].Value.ToString());

            var mensagem = string.Empty;
            var clienteService = new ServiceClientes.ServiceClienteClient();
            var cliente = clienteService.Listar(1).Where(x => x.Id == id).FirstOrDefault();

            var clienteAtualizado = new Cliente
            {

                Id = cliente.Id,
                CPF = e.NewValues["CPF"].ToString(),
                Nome = e.NewValues["Nome"].ToString(),
                RG = e.NewValues["RG"].ToString(),
                Sexo = e.NewValues["Sexo"].ToString(),


                Bairro = cliente.Bairro,
                CEP = cliente.CEP,
                Cidade = cliente.Cidade,
                Complemento = cliente.Complemento,
                DataExpedicao = cliente.DataExpedicao,
                DataNascimento = cliente.DataNascimento,
                EstadoCivil = cliente.EstadoCivil,
                Logradouro = cliente.Logradouro,
                Numero = cliente.Numero,
                OrgaoExpedicao = cliente.OrgaoExpedicao,
                UF = cliente.UF,
                UF_Expedicao = cliente.UF_Expedicao
            };


            clienteService.Atualizar(clienteAtualizado, ref mensagem);

            preencheGrid();
            ClienteGridView.EditIndex = -1;
            formCadastrocampos.Visible = true;
            formListaCliente.Visible = false;

        }


        protected void ClienteGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(ClienteGridView.DataKeys[e.RowIndex].Value.ToString());
            var mensagem = string.Empty;
            var clienteService = new ServiceClientes.ServiceClienteClient();
            clienteService.Excluir(id, ref mensagem);
            preencheGrid();
            ClienteGridView.EditIndex = -1;
            formCadastrocampos.Visible = true;
            formListaCliente.Visible = false;
        }



        protected void ClienteGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            //Reset the edit index.
            ClienteGridView.EditIndex = -1;
            //Bind data to the GridView control.
            preencheGrid();

            formCadastrocampos.Visible = true;
            formListaCliente.Visible = false;
        }
    }
}