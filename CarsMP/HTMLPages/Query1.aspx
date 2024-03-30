<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Query1.aspx.cs" Inherits="CarsMP.HTMLPages.Query_1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


        <meta charset="utf-8" />
    <title> Admins Control Page, Show all Users that have the letter 'a' in their First Names....... </title>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



           <%= st %>


      <h3 style="margin-bottom:50px;"><%= msg %></h3>


</asp:Content>
