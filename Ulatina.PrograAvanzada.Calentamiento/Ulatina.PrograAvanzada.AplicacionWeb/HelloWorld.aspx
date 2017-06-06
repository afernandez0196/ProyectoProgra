<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Ulatina.PrograAvanzada.AplicacionWeb.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmCalentamiento" runat="server" title="Forma de prueba temporal">
        <div style="height: 290px" title="Hello world">
            Hello world<br />
            Parámetros de entrada:<br />
            <asp:Calendar ID="cldFechaDeEntrada" runat="server" OnSelectionChanged="cldFechaDeEntrada_SelectionChanged"></asp:Calendar>
            <br />
            Fecha seleccionada: <asp:Label ID="lblFechaSeleccionada" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
