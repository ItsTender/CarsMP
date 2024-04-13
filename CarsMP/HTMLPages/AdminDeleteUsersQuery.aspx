<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminDeleteUsersQuery.aspx.cs" Inherits="CarsMP.HTMLPages.AdminDeleteUsersQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


                <meta charset="utf-8" />
    <title> Admins Control Page, select field, show users and delete button to delete them all ....... </title>

    <script src="../JavaScript/detectField.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>

<h3 style="margin-bottom:50px; margin-top:50px;"> <%= st %> </h3>


<h3 style="margin-bottom:50px;"><%= msg %></h3>


<h3 style="margin-bottom:50px;"><%= stdelete %></h3>

    </div>

</asp:Content>
