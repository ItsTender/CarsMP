<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Query4.aspx.cs" Inherits="CarsMP.HTMLPages.Query4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <meta charset="utf-8" />
    <title> Admins Control Page, Show all Users that use 'Gmail' and were born between 2000 to- 2007....... </title>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <% if(Session["admin"].ToString() == "yes") { %>
    
    <a> <%= st %> </a>

    <%} %>    


      <h3 style="margin-bottom:50px;"><%= msg %></h3>


</asp:Content>
