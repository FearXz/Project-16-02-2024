<%@ Page Title="Carrello" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Project_16_02_2024.Carrello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex align-content-center">
        <h2 id="intestazioneCarrello" class="me-3" runat="server">Carrello - </h2>
        <h2 id="totaleCarrello" runat="server">Totale: 0</h2>
        <div class="ms-3">
            <asp:Button ID="DeleteAll" runat="server" CssClass="btn btn-secondary mt-1" Text="Delete All" OnClick="DeleteAll_Click" />
        </div>
    </div>
    <main class="d-flex  flex-wrap">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="card mx-2 my-2 bg-dark text-white border border-white" style="width: 200px">
                    <img src='<%# Eval("UrlImage") %>' class="card-img-top img-fluid" alt='<%# Eval("Nome") %>'>
                    <div class="card-body d-flex flex-column justify-content-between">
                        <div>
                            <h5 class="card-title"><%# Eval("Nome") %></h5>
                            <p class="card-text"><%# Eval("Prezzo", "{0:c2}") %></p>
                        </div>

                        <div class="d-flex justify-content-between">
                            <a href='<%# "Dettagli.aspx?IdProdotto=" + Eval("Id") %>' class="btn btn-sm btn-secondary">Dettagli</a>
                            <asp:Button ID="DeleteFromCart" CssClass="btn btn-sm btn-secondary" runat="server" Text="Delete" OnClick="DeleteFromCart_Click" CommandArgument='<%# Eval("Id") %>' />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </main>
</asp:Content>
