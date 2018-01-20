<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web07DepartamentosEmpleados.aspx.cs" Inherits="WebAdo_Web07DepartamentosEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 219px;
        }
        .auto-style2 {
            width: 100%;
            height: 215px;
        }
        .auto-style3 {
            width: 276px;
        }
        .auto-style4 {
            width: 403px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style1">
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="lblDepartamentos" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:Label ID="lblEmpleados" runat="server"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="lbnumeropersonas" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="lbsumasalarial" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="lbcontrol" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="lblpruebas" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
