<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="SpecialCars.aspx.cs" Inherits="CarsMP.HTMLPages.SpecialCars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


         <meta charset="utf-8" />
 <title> Top 3 Special Cars </title>


 <style>
        
body {
    justify-content: center;
    align-items: center;
    background-color: whitesmoke;
}

h1 {
    text-align: center;
    font-family: serif;
    position: relative;
    font-size: 4vw;
    color: lightgray;
    -webkit-text-stroke: 2px gray;
    text-transform: uppercase;
}

    h1::before {
        content: attr(data-text);
        position: absolute;
        top: 0;
        left: 41.125%;
        height: 100%;
        width: 0;
        color: deepskyblue;
        -webkit-text-stroke: 0vw gray;
        border-right: 2px solid deepskyblue;
        overflow: hidden;
        animation: animate 5s linear infinite;
    }

@keyframes animate {

    0%,10%,100% {
        width: 0;
    }

    70%,90% {
        width: 17.825%;
    }
}

h4 {
    text-align: left;
    color: black;
    font-family: Calibri;
}

h2 {
    text-align: center;
    color: black;
    font-family: serif;
}


 </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



       <h3 style="margin-bottom:50px;"><%= msg %></h3>


       <%= st %>
         


</asp:Content>
