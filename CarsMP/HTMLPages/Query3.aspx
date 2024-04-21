<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Query3.aspx.cs" Inherits="CarsMP.HTMLPages.Query3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


        <meta charset="utf-8" />
    <title> Admins Control Page, Show all Users that use 'Gmail' and live in Nazareth, Jerusalem or Tel Aviv....... </title>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <% if(Session["admin"].ToString() == "yes") { %>
    
    <a> <%= st %> </a>

    <%} %>    


      <h3 style="margin-bottom:50px;"><%= msg %></h3>


</asp:Content>
