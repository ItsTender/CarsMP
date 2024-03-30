<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Intro.aspx.cs" Inherits="CarsMP.HTMLPages.Intro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
     <meta charset="utf-8" />
 <title> Top 5 Favourite Cars Introduction Page </title>


    <style>

body {
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
        left: 43.275%;
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
        width: 13.4%;
    }
}

h4 {
    text-align: left;
    color: black;
    font-family: Calibri;
}

h2 {
    text-align: center;
    font-size:large;
    color: black;
    font-family: serif;
}


        </style>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <h1 data-text="Intro" style="font-family:serif"> Intro </h1>

    <h2 style="font-family:'Century Gothic'">

        Welcome to My Favourite Cars Website, where automotive passion meets expert curation! presenting to you the definitive list of the top 8 cars that redefine automotive excellence. Our journey goes beyond the surface, delving into the heart and soul of each automobile to provide you with an immersive experience that transcends the ordinary.

in this Website, we pride ourselves on offering more than just a glance under the hood. We take you on a captivating exploration of each car's performance, unearthing the engineering marvels that propel them to greatness. From zero to sixty, corner to corner, we dissect the numbers and unveil the stories that make these cars true legends on the road.

But it doesn't stop there. Join us as we navigate through the rich tapestry of automotive history, revealing the milestones that shaped these automotive masterpieces. Every car has a story, and we are here to narrate it—connecting you with the heritage and evolution that brought these icons to life.

Beyond the technicalities, we appreciate the artistry that transforms these vehicles into rolling works of art. The sleek curves, the aerodynamic designs, and the meticulous attention to detail—all captured and celebrated in our exploration of each car's aesthetics. Prepare to be captivated by the visual symphony that defines automotive beauty.

Whether you're a seasoned car connoisseur or a casual admirer, i invites you to buckle up for an unparalleled journey through the world of automobiles. Join us as we navigate the fast lanes of performance, rewind the gears of history, and bask in the sheer elegance of automotive design.

Your adventure begins here where passion meets precision, and the road ahead is paved with the stories of the world's top 8 cars, as seen through my eyes and experienced through yours. Welcome to the driver's seat of automotive excellence!

        Some explicit members can expect a wider range of content here in my website...


    </h2>


    <br/>

        <h4 style="text-align:center"> <a href="Cars.aspx" style="color:deepskyblue; font-size:xx-large ;font-family:Calibri; font-style:oblique;"> Click to Start → </a> </h4>


         <h4 style="text-align:center"> 
             <a href="Cars.aspx">  
             <img src="../Images/PorscheDrift.gif" />
             </a>
         </h4>





</asp:Content>
