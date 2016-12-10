<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="lister.aspx.cs" Inherits="TP2.WebForm1" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="div1" align="left">
        <asp:Label ID="Label1" runat="server" Text="Inserer le Montant à Convertir"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="text" runat="server"></asp:TextBox>
        <asp:RangeValidator 
            ID="RangeValidator1" runat="server" 
            ErrorMessage="Peut seulement convertir des chiffres" 
            ControlToValidate="text" ForeColor="Red" MaximumValue="99999" 
            MinimumValue="0.000000001"></asp:RangeValidator>
        <asp:Table ID="Table1" runat="server" GridLines="Horizontal">
    <asp:TableRow  runat="server" BackColor="#9999FF">
        <asp:TableCell ID="TableCell1" runat="server">Type de monnaie</asp:TableCell>
    </asp:TableRow>
</asp:Table>
    </div>
     <td class="style3">
           <asp:Label ID="Label9" runat="server" Text="Resultat :"></asp:Label>
     </td>
    <td class="style4">
         <asp:Label ID="lMessage" runat="server" ForeColor="#0033CC" 
    Visible="False"></asp:Label>
    </td>
</asp:Content>
