<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarsMP.HTMLPages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


            <meta charset="utf-8" />
    <title> Login to my Website </title>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form method="post" runat="server">

        <table style="width:800px">

        <tr>
            <td colspan="2"><h2 style="color:deepskyblue;"> Login with Existing Account </h2></td>
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
