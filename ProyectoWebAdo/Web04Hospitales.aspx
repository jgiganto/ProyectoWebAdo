<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web04Hospitales.aspx.cs" Inherits="Web04Hospitales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="HOSPITALES"></asp:Label>
        </div>
        <asp:ListBox ID="lsthospitales" runat="server" Height="171px" Width="154px" OnSelectedIndexChanged="lsthospitales_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        <div> 
            <asp:Button ID="btnverempleados" runat="server" OnClick="btnverempleados_Click" Text="Ver empleados" Width="152px" />
            <br />
            <br />
        </div>
        <div> 
            <asp:Label ID="Label2" runat="server" Text="Incremento: "></asp:Label>
&nbsp;
            <asp:TextBox ID="txtincremento" runat="server" Width="111px"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnincrementar" runat="server" OnClick="btnincrementar_Click" Text="Incrementar Salario" />
            <br />
            <br />
        </div>
        <div> 
            <asp:Label ID="lbmostrartabla" runat="server" Text="Tabla"></asp:Label>
        </div>
    </form>
</body>
</html>
