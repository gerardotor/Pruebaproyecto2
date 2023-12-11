<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Pruebaproyecto2.Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Mantenimiento de Equipos</h2>
        <div>
            <h3>Agregar Equipo</h3>
            <asp:TextBox ID="txtTipoEquipo" runat="server" placeholder="Tipo de Equipo" OnTextChanged="txtTipoEquipo_TextChanged1"></asp:TextBox>
            <asp:TextBox ID="txtModeloEquipo" runat="server" placeholder="Modelo" OnTextChanged="txtModeloEquipo_TextChanged"></asp:TextBox>
<asp:Button ID="btnGuardarEquipo" runat="server" Text="Guardar Equipo" OnClick="btnGuardarEquipo_Click" BackColor="Blue" />
            
        </div>

      

       
        <div>
            <h3>Listado de Equipos</h3>
            <asp:GridView ID="gridEquipos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridEquipos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="EquipoID" HeaderText="ID Equipo" ReadOnly="True" />
                    <asp:BoundField DataField="TipoEquipo" HeaderText="Tipo de Equipo" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>

