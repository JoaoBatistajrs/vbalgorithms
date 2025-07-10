<%@ Page Title="Poker Hand Evaluator" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PokerHand.aspx.vb" Inherits="WebFormsAlgorithms.PokerHand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="mb-4">Poker hand checker</h2>
    <hr />

    <div class="card p-4 shadow-sm rounded-3">
        <div class="row g-3 mb-4">
            <div class="col-md-2">
                <label for="txtCard1" class="form-label">Card 1:</label>
                <asp:TextBox ID="txtCard1" runat="server" CssClass="form-control" placeholder="Ex: AS, 10H"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label for="txtCard2" class="form-label">Card 2:</label>
                <asp:TextBox ID="txtCard2" runat="server" CssClass="form-control" placeholder="Ex: AS, 10H"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label for="txtCard3" class="form-label">Card 3:</label>
                <asp:TextBox ID="txtCard3" runat="server" CssClass="form-control" placeholder="Ex: AS, 10H"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label for="txtCard4" class="form-label">Card 4:</label>
                <asp:TextBox ID="txtCard4" runat="server" CssClass="form-control" placeholder="Ex: AS, 10H"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <label for="txtCard5" class="form-label">Card 5:</label>
                <asp:TextBox ID="txtCard5" runat="server" CssClass="form-control" placeholder="Ex: AS, 10H"></asp:TextBox>
            </div>
        </div>

        <div class="d-grid gap-2 d-md-flex justify-content-md-start mb-4">
            <asp:Button ID="btnEvaluate" runat="server" Text="Evaluate Cards" CssClass="btn btn-primary btn-lg" OnClick="btnEvaluate_Click" />
        </div>

        <div class="mt-3">
            <asp:Label ID="lblResult" runat="server" EnableViewState="false" Font-Bold="True" CssClass="fs-4"></asp:Label>
        </div>
    </div>
</asp:Content>