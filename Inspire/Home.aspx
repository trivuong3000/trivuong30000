<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Inspire.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main">
       <div class="banner">
           <div class="banner__content">
               <h1 class="banner__title">LaMa_Blogs</h1>
               <h4 class="banner__desc">Is where inspiration happens</h4>
               <a href="#containerContent" class="banner__action">Start now</a>
           </div>
       </div>
       <h1>Blog</h1>
       <div class="container" id="containerContent">
           <div class="row">
               <div class="home" id="homeContent" runat="server">

               </div>
           </div>
       </div>
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Red"></asp:Label>
</asp:Content>
