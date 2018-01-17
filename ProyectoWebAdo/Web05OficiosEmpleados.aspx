<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web05OficiosEmpleados.aspx.cs" Inherits="Web05OficiosEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
        thead {
            color: green;
        }

        tbody {
            color: blue;
        }
        
        table, th, td {
            border: none;
            text-align:right;
        }
        
        .auto-style1 {
            width: 159px;
        }
        
        .auto-style2 {
            width: 113px;
        }
        .auto-style3 {
            width: 81px;
        }
        .auto-style4 {
            width: 80px;
        }
        .auto-style7 {
            width: 119px;text-align:left;
        }
        .auto-style8 {
            width: 35px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table border="0">
                <tr>
                    <td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OFICIOS</td>
                    <td class="auto-style1" >
                        <asp:ListBox ID="lstoficios" runat="server" Height="102px" Width="160px"></asp:ListBox>
                        <br />
                      
                        <asp:Button ID="btnfiltrar" runat="server" Text="FILTRAR" Width="164px" />
                    </td>
                    <td class="auto-style2"></td>
                    <td>&nbsp;&nbsp;&nbsp;
                        </td>
                    
                </tr>


            </table>

        </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style7">EMPLEADOS:</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
            <asp:Label ID="lblempleados" runat="server" Text="TABLAEMPLEADOS"></asp:Label>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>
                        <table >
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="auto-style3" >SALARIO&nbsp;&nbsp; </td>
                                            <td >
                                                <asp:TextBox ID="txtsalario" runat="server"></asp:TextBox>
                                            </td>

                                        </tr>

                                    </table>
                                </td>

                            </tr>
                            <tr>
                                <td >
                                    <table >
                                        <tr>
                                            <td>COMISION</td>
                                            <td>
                                                <asp:TextBox ID="txtcomision" runat="server"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btncambiar" runat="server" Text="CAMBIAR" Width="164px" />
                                            </td>

                                        </tr>

                                    </table>
                                </td>

                            </tr>
                            <tr>
                                <td class="auto-style15">
                                    <table >
                                        <tr>
                                            <td class="auto-style4">OFICIO</td>
                                            <td>
                                                <asp:TextBox ID="txtoficio" runat="server"></asp:TextBox>
                                            </td>

                                        </tr>

                                    </table>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="auto-style4" >EMPNO</td>
                                            <td>
                                                <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
                                            </td>

                                        </tr>

                                    </table>
                                </td>

                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
        <div>
            <div>
                    </div>
        </div>
    </form>
</body>
</html>
