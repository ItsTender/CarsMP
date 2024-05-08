<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Specs.aspx.cs" Inherits="CarsMP.HTMLPages.Specs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




    <meta charset="utf-8" />
<title>  Specs of The Cars Shown </title>
    <link href="../StyleSheets/StyleSheetTable.css" rel="stylesheet" />



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



 <table style="margin-top: 10px">
     <tr style="background: whitesmoke; border: whitesmoke;">
             <h2 style="color:deepskyblue;"> Car Specifications </h2>
     </tr>
     <tr>
         <th> Manufacturer </th>
         <th> Model </th>
         <th> Engine </th>
         <th> Hrosepower </th>
     </tr>
     <tr>
         <td class="class1"> Mercedes </td>
         <td class="class2"> AMG One </td>
         <td class="class3"> Turbo Hybrid V6 </td>
         <td class="class4"> 1063 </td>
     </tr>
     <tr>
         <td class="class1"> Porsche </td>
         <td class="class2"> Carrera GT </td>
         <td class="class3"> NA V10 </td>
         <td class="class4"> 603 </td>
     </tr>
     <tr>
         <td class="class1"> Ferrari </td>
         <td class="class2"> SF90 Stradale </td>
         <td class="class3"> Hybrid V8 </td>
         <td class="class4"> 986 </td>
     </tr>
     <tr>
         <td class="class1"> Chevrolet </td>
         <td class="class2"> Corvette ZO6 </td>
         <td class="class3"> NA V8 </td>
         <td class="class4"> 670 </td>
     </tr>
     <tr>
         <td class="class1"> BMW </td>
         <td class="class2"> M2 </td>
         <td class="class3"> Trubo I6 </td>
         <td class="class4"> 453 </td>
     </tr>
     <tr>
         <td class="class1"> Audi </td>
         <td class="class2"> RS6 Avant </td>
         <td class="class3"> Twin Turbo V8 </td>
         <td class="class4"> 591 </td>
     </tr>
     <tr>
         <td class="class1"> Toyota </td>
         <td class="class2"> GR Yaris </td>
         <td class="class3"> Turbo I3 </td>
         <td class="class4"> 257 </td>
     </tr>
     <tr>
         <td class="class1"> Renault </td>
         <td class="class2"> Megane RS </td>
         <td class="class3"> Turbo I4 </td>
         <td class="class4"> 300 </td>
     </tr>
 </table>

        <br>
     
<a href="Cars.aspx"> 
    <img src="../Images/Back_Arrow.png" title="Back To Main" alt="BackArrow" height="88">
</a>


</asp:Content>
