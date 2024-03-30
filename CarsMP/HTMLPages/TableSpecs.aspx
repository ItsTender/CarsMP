<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="TableSpecs.aspx.cs" Inherits="CarsMP.HTMLPages.TableSpecs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


<meta charset="utf-8" />
<title> A Table of Specs of The Cars Shown </title>


    <style> 


body {
    background-color: whitesmoke;
}

.class1 {
    background-color: darkslategray;
    font-family: Calibri;
}

.class2 {
    background-color: #2a566e;
    font-family: Calibri;
}

.class3 {
    background-color: dodgerblue;
    font-family: Calibri;
}

.class4 {
    background-color: deepskyblue;
    font-family: Calibri;
}

table {
    text-align: center;
}

td {
    width: 220px;
    height: 40px;
    border: 1px solid dimgray;
    font-size: 1.25vw;
    color: whitesmoke;
    font-family: Calibri;
}

th {
    width: 220px;
    height: 40px;
    border: 2.5px solid gray;
    font-size: 1.88vw;
    color: whitesmoke;
    font-family: Calibri;
        background-color: dimgray;
}


    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <br>

 <table>
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
         <td class="class1"> Renault </td>
         <td class="class2"> Megane RS </td>
         <td class="class3"> Turbo I4 </td>
         <td class="class4"> 300 </td>
     </tr>
     <tr>
         <td class="class1"> Toyota </td>
         <td class="class2"> GR Yaris </td>
         <td class="class3"> Turbo I3 </td>
         <td class="class4"> 257 </td>
     </tr>
 </table>

        <br>
     
<a href="Cars.aspx"> 
    <img src="../Images/Back_Arrow.png" title="Back To Main" alt="BackArrow" height="88">
</a>



</asp:Content>
