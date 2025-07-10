<%@ Page Title="Palindrome Checker" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Palindrome.aspx.vb" Inherits="WebFormsAlgorithms.Palindrome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Palindrome Checker</h2>
    <hr />
    <div class="form-group">
        <label for="txtNumber">Enter a number:</label>
        <asp:TextBox ID="txtNumber" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
    </div>
    <div class="mt-3">
        <asp:Button ID="btnCheckPalindrome" runat="server" Text="Verify" CssClass="btn btn-primary" OnClick="btnCheckPalindrome_Click" />
    </div>
    <div class="mt-4">
        <asp:Label ID="lblResult" runat="server" EnableViewState="false" Font-Bold="True"></asp:Label>
    </div>
</asp:Content>


