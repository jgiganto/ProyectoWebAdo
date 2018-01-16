<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web05OficiosEmpleados.aspx.cs" Inherits="Web05OficiosEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 76px;
        }
        .auto-style2 {
            width: 90%;
            height: 152px;
        }
        .auto-style4 {
            width: 275px;
        }
        .auto-style5 {
            width: 98%;
            height: 203px;
        }
        .auto-style7 {
            width: 78px;
            height: 9px;
        }
        .auto-style8 {
            height: 9px;
        }
        .auto-style10 {
            height: 11px;
        }
        .auto-style13 {
            width: 100%;
            height: 40px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table border="0" class="auto-style2">
                <tr>
                    <td class="auto-style1">OFICIOS</td>
                    <td class="auto-style4">
                        <asp:ListBox ID="lstoficios" runat="server" Height="102px" Width="160px"></asp:ListBox>
                        <br />
                        <br />
                        <asp:Button ID="btnfiltrar" runat="server" Text="FILTRAR" Width="164px" />
                    </td>
                    <td>
                        <table class="auto-style5">
                            <tr>
                                <td class="auto-style10">
                                    <table class="auto-style13">
                                        <tr>
                                            <td class="auto-style7">SALARIO</td>
                                            <td class="auto-style8">
                                                <asp:TextBox ID="txtsalario" runat="server"></asp:TextBox>
                                            </td>
                                           
                                        </tr>
                                                                                
                                    </table>
                                </td>
                                
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <table class="auto-style13">
                                        <tr>
                                            <td class="auto-style7">COMISION</td>
                                            <td class="auto-style8">
                                                <asp:TextBox ID="txtcomision" runat="server"></asp:TextBox>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btncambiar" runat="server" Text="CAMBIAR" Width="164px" />
                                            </td>
                                           
                                        </tr>
                                                                                
                                    </table>
                                </td>
                             
                            </tr>
                            <tr>
                               <td class="auto-style10">
                                    <table class="auto-style13">
                                        <tr>
                                            <td class="auto-style7">OFICIO</td>
                                            <td class="auto-style8">
                                                <asp:TextBox ID="txtoficio" runat="server"></asp:TextBox>
                                            </td>
                                           
                                        </tr>
                                                                                
                                    </table>
                                </td>
                              
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <table class="auto-style13">
                                        <tr>
                                            <td class="auto-style7">EMPNO</td>
                                            <td class="auto-style8">
                                                <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
                                            </td>
                                           
                                        </tr>
                                                                                
                                    </table>
                                </td>
                              
                            </tr>
                        </table>
                    </td>
                </tr>
                
             
            </table>
            
        </div>
         <div>
             EMPLEADOS:<br />
        </div>
        <div>
            <asp:Label ID="lblempleados" runat="server" Text="TABLAEMPLEADOS"></asp:Label>
        </div>
    </form>
</body>
</html>
