<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminShowUsers.aspx.cs" Inherits="CarsMP.HTMLPages.AdminShowUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <meta charset="utf-8" />
    <title> Admins Control Page, Show Users! </title>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


       <%= st %>


      <h3 style="margin-bottom:50px;"><%= msg %></h3>


</asp:Content>
