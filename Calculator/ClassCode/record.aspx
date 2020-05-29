<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="record.aspx.cs" Inherits="Calculator.ClassCode.record" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="calculator">
    <asp:Button ID="btnRecord" CssClass="btn btn-success" runat="server" Text="Historial" OnClick="btnRecord_Click" />
    <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Borrar" OnClick="btnDelete_Click" Enabled="False" />

    <br />
    <asp:Label ID="lblRecord"  runat="server" Height="40px" Width="300px" Text=""></asp:Label>
    </div>
   
  
</asp:Content>
