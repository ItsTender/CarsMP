<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminControl.aspx.cs" Inherits="CarsMP.HTMLPages.AdminControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <meta charset="utf-8" />
    <title> Admins Control Page, delete, show users....... </title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 style="font-size:50px">Admin Control Page</h1>

     &nbsp;

    <h3><% Response.Write(msg); %></h3>
    &nbsp;

</asp:Content>
