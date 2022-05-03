<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="WebForms.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/Site.css" rel="stylesheet" />
    <title></title>
</head>
<body>



    <form id="formCadastro" runat="server">


        <div class="group-linha">
            <div class="group-label-input">
                <div>
                    <asp:Button runat="server" ID="btnTelaCadastro" CssClass="btn-menu" Text="Cadastrar" Height="38px" Width="123px" OnClick="btnTelaCadastro_Click" />
                    <asp:Button ID="btnTelaListagem" CssClass="btn-menu" runat="server" Text="Lista" Height="38px" Width="123px" OnClick="btnTelaListagem_Click" />
                </div>
            </div>
        </div>

        <div id="formListaCliente" runat="server">
            <div class="group-label-input">
                <div>
                    <asp:GridView ID="ClienteGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="223px" OnRowDeleting="ClienteGridView_RowDeleting" OnRowEditing="ClienteGridView_RowEditing" OnRowUpdating="ClienteGridView_RowUpdating" OnSelectedIndexChanged="ClienteGridView_SelectedIndexChanged" Width="740px" OnRowCancelingEdit="ClienteGridView_RowCancelingEdit">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:BoundField DataField="CPF" HeaderText="CPF" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="RG" HeaderText="RG" />
                            <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </div>
            </div>

        </div>



        <div id="formCadastrocampos" runat="server">

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label1" class="legenda-input" runat="server" Text="CPF:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtCPF" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaCPF" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label2" class="legenda-input" runat="server" Text="Nome"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtNome" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaNome" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label3" class="legenda-input" runat="server" Text="RG:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtRG" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label4" class="legenda-input" runat="server" Text="Data Expedição:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtDataExpedicao" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>

                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label5" class="legenda-input" runat="server" Text="Orgão Expedição:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtOrgaoExpedicao" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                </div>
            </div>


            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label6" class="legenda-input" runat="server" Text="UF Expedição:"></asp:Label>
                    </div>

                    <asp:DropDownList ID="dropUFExpedicao" class="input-login" runat="server" Height="35px" Width="273px">
                        <asp:ListItem Text="SP" Value="SP" />
                        <asp:ListItem Text="GO" Value="GO" />
                    </asp:DropDownList>

                </div>
            </div>


            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label8" class="legenda-input" runat="server" Text="Data de Nascimento:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtDataNascimento" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaDataNascimento" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label9" class="legenda-input" runat="server" Text="Sexo:"></asp:Label>
                    </div>

                    <asp:DropDownList ID="DropSexo" class="input-login" runat="server" Height="35px" Width="273px">
                        <asp:ListItem Text="M" Value="M" />
                        <asp:ListItem Text="F" Value="F" />
                        <asp:ListItem Text="OUTROS" Value="OUTROS" />
                    </asp:DropDownList>
                    <div>
                        <asp:Label ID="validaSexo" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label10" class="legenda-input" runat="server" Text="Estado Civil:"></asp:Label>
                    </div>

                    <asp:DropDownList ID="DropEstadoCivil" class="input-login" runat="server" Height="35px" Width="273px">
                        <asp:ListItem Text="CASADO" Value="CASADO" />
                        <asp:ListItem Text="SOLTEIRO" Value="SOLTEIRO" />
                        <asp:ListItem Text="OUTROS" Value="OUTROS" />
                    </asp:DropDownList>
                    <div>
                        <asp:Label ID="validaEstadoCivil" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label7" class="legenda-input-separacao" runat="server" Text="UF Expedição:"></asp:Label>
                    </div>

                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label11" class="legenda-input" runat="server" Text="CEP:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtCEP" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaCEP" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label12" class="legenda-input" runat="server" Text="Rua:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtRua" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaRua" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label13" class="legenda-input" runat="server" Text="Numero:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtNumero" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaNumero" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label17" class="legenda-input" runat="server" Text="Complemento:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtComplemento" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label14" class="legenda-input" runat="server" Text="Bairro:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtBairro" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaBairro" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label15" class="legenda-input" runat="server" Text="Cidade:"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtCidade" class="input-login" runat="server" Height="35px" Width="273px"></asp:TextBox>
                    <div>
                        <asp:Label ID="validaCidade" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Label ID="Label16" class="legenda-input" runat="server" Text="UF"></asp:Label>
                    </div>

                    <asp:DropDownList ID="DropUF" class="input-login" runat="server" Height="35px" Width="273px">
                        <asp:ListItem Text="SP" Value="SP" />
                        <asp:ListItem Text="GO" Value="GO" />
                    </asp:DropDownList>
                    <div>
                        <asp:Label ID="validaUF" class="legenda-input-erro" runat="server" Text="Campo Obrigatório" Visible="False"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <br />
                    </div>
                </div>
            </div>


            <div class="group-linha">
                <div class="group-label-input">
                    <div>
                        <asp:Button ID="btnSalvar" CssClass="btn-acao" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                    </div>
                </div>
            </div>

        </div>

    </form>
</body>
</html>
