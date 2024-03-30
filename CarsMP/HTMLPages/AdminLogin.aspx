<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="CarsMP.HTMLPages.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta charset="utf-8" />
    <title> Only Admins </title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form method="post" runat="server">

    <table style="width:800px">

    <tr>
        <td colspan="2"><h2 style="color:firebrick; font-size:40px;"> Admins Login Page </h2></td>
    </tr>

    <tr>
        <br />
     </tr>

     <tr> 
         <td> Username: </td>
         <td><input type="text"; id="username"; name="username" required/> </td>
     </tr>


     <tr>
          <td> Password: </td>
          <td><input type="password"; id="password"; name="password" required/></td>
     </tr>

    <tr></tr>

     <tr>
          <td colspan="2" style="text-align:center;">
          <input type="submit" name="submit" value="Login" /> </td>
     </tr>

      </table>


      <br />

    <h2 style="font-size:xx-large">
        <% Response.Write(msg); %> 
    </h2>


 </form>


</asp:Content>
