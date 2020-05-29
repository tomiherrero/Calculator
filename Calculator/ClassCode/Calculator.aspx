<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.ClassCode.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="calculator">
    <asp:RadioButton ID="rdoSum" runat="server" Text="Suma" GroupName="rbn" Checked="True" />
    <asp:RadioButton ID="rdoSubtraction" runat="server" Text="Resta" GroupName="rbn" />
    <asp:RadioButton ID="rdoMultiply" runat="server" Text ="Multiplicar" GroupName="rbn"/>
    <asp:RadioButton ID="rdoDivide" runat="server" Text="Dividir" GroupName="rbn" />
    <br />

    <asp:Label ID="lblNumberObligatory1" runat="server" Text="*Campo Obligatorio" Visible="False" ></asp:Label>
    <asp:TextBox ID="txtNumber1" CssClass="form-control" runat="server" Height="40px" Width="300px" onkeypress="if (isNaN(String.fromCharCode(event.keyCode))) return false;" OnTextChanged="txtNumber1_TextChanged" ></asp:TextBox>
    <br />
    <asp:Label ID="lblNumberObligatory2" runat="server" Text="*Campo Obligatorio" Visible="False"></asp:Label>
    <asp:TextBox ID="txtNumber2" CssClass="form-control" runat="server" Height="40px" Width="300px" onkeypress="if (isNaN(String.fromCharCode(event.keyCode))) return false;" OnTextChanged="txtNumber2_TextChanged" ></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="lblResult" CssClass="form-control" runat="server"  Height="40px" Width="300px"  ></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnCalculate" CssClass="btn btn-success" runat="server" Text="Calcular" OnClick="btnCalculate_Click" />
    <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Borrar" OnClick="btnDelete_Click" />
    <asp:Button ID="txtResult" CssClass="btn btn-dark" runat="server" Text="Ver Resultados" OnClick="txtResult_Click" />
</div>




</asp:Content>
