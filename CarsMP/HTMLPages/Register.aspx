<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CarsMP.HTMLPages.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <meta charset="utf-8" />
    <title> Signup to my WebSite </title>
    <script src="../JavaScript/checkRegistration.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form method="post" runat="server" onsubmit="return CheckForm()">

    <table style="border: 0px solid white ; margin: 0px auto;" width="1000px">

        <tr>
            <td colspan="3"><h2 style="color:deepskyblue;"> Registration Form </h2></td>
        </tr>

        <tr></tr>

        <tr>
            <td> Username: </td>
            <td><input type="text"; id="username"; name="username" required/></td>
            <td> <input type="text"; id="mUName"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>
        </tr>


        <tr>
                    <td> First Name: </td>
            <td><input type="text"; id="firstName"; name="firstName" required/></td>
            <td> <input type="text"; id="mFName"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>
        </tr>


        <tr>
                     <td> Last Name: </td>
            <td><input type="text"; id="lastName"; name="lastName" required/></td>
            <td> <input type="text"; id="mLName"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>
        </tr>


        <tr>
                      <td> Email Adress: </td>
            <td><input type="text"; id="email"; name="email" required/></td>
            <td> <input type="text"; id="mEmail"; size="30"; style="display:none; background-color:silver; width:300px;" disabled="disabled" /> </td>
        </tr>
        

        <tr>
                      <td> Year Born: </td>
            <td><select id="year" name="year"> <%= yrBorn  %> </select></td>
        </tr>

        
        <tr>
                      <td> Gender: </td>
            <td>
                <input type="radio" name="gender" value="male" checked /> male
                <input type="radio" name="gender" value="female" /> female

            </td>
        </tr>


        <tr>
                      <td> Phone Number: </td>
            <td>

            <select name="prefix"> 

                <option value="050"> 050 </option>
                <option value="052"> 052 </option>
                <option value="053"> 053 </option>
                <option value="054"> 054 </option>
                <option value="055"> 055 </option>
                <option value="057"> 057 </option>
                <option value="058"> 058 </option>
                <option value="02"> 02 </option>
                <option value="03"> 03 </option>
                <option value="04"> 04 </option>
                <option value="08"> 08 </option>
                <option value="09"> 09 </option>
                <option value="077"> 077 </option>

            </select>

               <a> &nbsp </a>

              <input type="number"; id="Phone"; name="Phone" required/>

            </td>

            <td> <input type="text"; id="mPhone"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>

        </tr>


       <tr>
                      <td> City: </td>
                      <td>

                          <select name="city"> 

    <option value="Nazareth"> Nazareth </option>
    <option value="Safed"> Safed </option>
    <option value="Afula"> Afula </option>
    <option value="Haifa"> Haifa </option>
    <option value="Tiberias"> Tiberias </option>
    <option value="Karmiel"> Karmiel </option>
    <option value="Acre"> Acre </option>
    <option value="Netanya"> Netanya </option>
    <option value="Nablus"> Nablus </option>
    <option value="Tel Aviv"> Tel Aviv </option>
    <option value="Ramallah"> Ramallah </option>
    <option value="Jerusalem"> Jerusalem </option>
    <option value="Ashkelon"> Ashkelon </option>
    <option value="Gaza"> Gaza </option>
    <option value="Beer Sheva"> Beer Sheva </option> 
    <option value="Eilat"> Eilat </option>

                         </select>

                      </td>
            <td> <input type="text"; id="mCity"; size="30"; style="display:none; background-color:silver;" disabled="disabled"/> </td>
        </tr>


        <tr>
            <td> Hobies: </td>

            <td><input id="hobies" type ="checkbox" name ="hobies" value ="Football" /> Football
    &nbsp; 
    <input type = "checkbox" name = "hobies" value = "Basket Ball" / /> Basket Ball
    &nbsp;
    <input type = "checkbox" name = "hobies" value = "Swimming" /> Swimming
    &nbsp;
    <input type = "checkbox" name = "hobies" value = "Programming" /> Programming
    &nbsp;
    <input type = "checkbox" name = "hobies" value = "Video Games" /> Video Games
    &nbsp;
            </td>
            <td> <input type="text"; id="mHobies"; size="30"; style="display:none; background-color:silver;" disabled="disabled"/> </td>

        </tr>


        <tr>
                      <td> Password: </td>
                      <td><input type="password"; id="password"; name="password" required/></td>
            <td> <input type="text"; id="mPassword"; size="30"; style="display:none; background-color:silver; width:300px;" disabled="disabled" /> </td>
        </tr>


        <tr>
            <td> Confirm Password: </td>
             <td><input type="password"; id="rePassword"; name="rePassword" required/></td>
        </tr>

        <tr></tr>

        <tr>
            <td colspan="3"> <input type="submit"; value="Register" ; name="submit"; id="submit" /></td>
        </tr>


    </table>

    </form>



   <h2 style="font-size:xx-large">
         &nbsp;
         <%  Response.Write(msg);  %>
   </h2>


</asp:Content>
