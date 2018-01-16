<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web02DatosEmpleados.aspx.cs" Inherits="Web02DatosEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Empleados<br />
            <br />
            <asp:ListBox ID="lstempleados" runat="server" Height="305px" Width="232px"></asp:ListBox>

        </div>
        <asp:Button ID="btnmostrar" runat="server" OnClick="btnmostrar_Click" Text="Mostrar datos" Width="205px" />
        <br />
        <br />
        <asp:Label ID="lbldatos" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
    </form>
</body>
</html>
