<%@ Page Title="Dettagli" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Project_16_02_2024.Dettagli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="d-flex">
            <div class="col-3">
                <div class="card mx-2 my-2 bg-dark text-white border border-white" style="width: 200px">
                    <img id="image" runat="server" src="" class="card-img-top img-fluid" alt="immagineProdotto">
                    <div class="card-body d-flex flex-column justify-content-between">
                        <div>
                            <h5 id="titolo" runat="server" class="card-title"></h5>
                            <p id="prezzo" runat="server" class="card-text"></p>
                        </div>
                        <div class="d-flex justify-content-between">
                            <asp:Button ID="addToCart" CssClass="btn btn-sm btn-secondary" runat="server" Text="Add To Cart" OnClick="addToCart_Click" CommandArgument="" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-9">
                <div>
                    <p id="descrizione" class="fs-1 bold" runat="server"></p>
                </div>
            </div>

        </div>

    </main>
</asp:Content>
