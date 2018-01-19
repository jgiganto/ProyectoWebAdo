<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web06SalasPlantilla.aspx.cs" Inherits="Web06SalasPlantilla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 228px;
        }
        .auto-style2 {
            width: 228px;
            height: 47px;
        }
        .auto-style3 {
            height: 47px;
        }
        .auto-style4 {
            width: 228px;
            height: 18px;
        }
        .auto-style5 {
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 240px">
            
            <table style="width: 100%; height: 356px;">
                <tr>
                    <td class="auto-style2">
                        <br />
                        <asp:Label ID="lblsalas" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="PLANTILLA"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblplantilla" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
