<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Inicioprueba.aspx.cs" Inherits="Pruebaproyecto2.Inicioprueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h2>Mantenimiento de Equipos</h2>

    <div>
        <h3>IInsertar/Actualizar Equipo</h3>
        <div>
            <asp:Label ID="lblTipoEquipo" runat="server" Text="Tipo de Equipo:"></asp:Label>
            <asp:TextBox ID="txtTipoEquipo" runat="server" OnTextChanged="txtTipoEquipo_TextChanged"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblModelo" runat="server" Text="Modelo:"></asp:Label>
            <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnGuardarEquipo" runat="server" Text="Guardar Equipo" OnClick="btnGuardarEquipo_Click" BackColor="Blue" />
    </div>

    <div>
        <h3>Listado de Equipos/h3>
        <asp:GridView ID="gridEquipos" runat="server" AutoGenerateColumns="False" OnRowEditing="gridEquipos_RowEditing"
            OnRowCancelingEdit="gridEquipos_RowCancelingEdit" OnRowUpdating="gridEquipos_RowUpdating" OnRowDeleting="gridEquipos_RowDeleting">
            <Columns>
                <asp:BoundField DataField="EquipoID" HeaderText="ID Equipo" ReadOnly="True" />
                <asp:BoundField DataField="TipoEquipo" HeaderText="Tipo de Equipo" />
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
