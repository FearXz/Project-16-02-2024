<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_16_02_2024._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="d-flex flex-wrap justify-content-between" >
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
                            <asp:Button ID="addToCart" CssClass="btn btn-sm btn-secondary" runat="server" Text="Add To Cart" OnClick="addToCart_Click" CommandArgument='<%# Eval("Id") %>' />
                        </div>

                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </main>

</asp:Content>
