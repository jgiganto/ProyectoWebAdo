<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web03BuscadorEmpleado.aspx.cs" Inherits="Web03BuscadorEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Introduzca un apellido"></asp:Label>
            <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
            <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Mostrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbldatos" runat="server" Text="Datos"></asp:Label>
        </div>
    </form>
</body>
</html>
