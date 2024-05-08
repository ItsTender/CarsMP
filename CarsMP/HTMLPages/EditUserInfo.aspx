<%@ Page Title="" Language="C#" MasterPageFile="~/CarsMasterPage.Master" AutoEventWireup="true" CodeBehind="EditUserInfo.aspx.cs" Inherits="CarsMP.HTMLPages.EditUserInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <meta charset="utf-8" />
    <title> Edit User Information for those who are logged in! </title>
    <script src="../JavaScript/CheckForm.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<form method="post" runat="server" onsubmit="return CheckForm();">

<table style="width:auto;height:auto;">

    <tr>
        <td colspan="3"><h2 style="color:deepskyblue;"> Edit User Info </h2></td>
    </tr>

    <tr></tr>

    <tr>
        <td> Username:</td>
        <td><input type="text"; id="username"; name="username" disabled="disabled" value="<%= uName %>"/></td>
        <td><input type="text"; id="mUName"; size="33"; style="display:none; background-color:silver;" disabled="disabled" /> </td>
    </tr>


    <tr>
        <td> First Name:</td>
        <td><input type="text"; id="firstName"; name="firstName" value="<%= fName %>" required/></td>
        <td> <input type="text"; id="mFName"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>
    </tr>


    <tr>
        <td> Last Name: </td>
        <td><input type="text"; id="lastName"; name="lastName" value="<%= lName %>" required/></td>
        <td> <input type="text"; id="mLName"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>
    </tr>


    <tr>
        <td> Email Adress: </td>
        <td><input type="text"; id="email"; name="email" value="<%= email %>" required/></td>
        <td> <input type="text"; id="mEmail"; size="30"; style="display:none; background-color:silver; width:300px;" disabled="disabled" /> </td>
    </tr>
    

    <tr>
        <td> Year Born: </td>
        <td><select id="year" name="year"> <%= yrBorn  %> </select></td>
    </tr>

    
    <tr>
        <td> Gender: </td>
        <td>
            
     <% if (gender == "male") {   %>
    <input type="radio" name="gender" value = "male" checked />male
    <input type="radio" name="gender" value = "female" />female
     <%}
         else
         { %>
    <input type="radio" name="gender" value = "male"  />male
    <input type="radio" name="gender" value = "female" checked/>female
     <%} %>
        </td>
    </tr>


    <tr>
        <td> Phone Number: </td>
        <td>

        <select name="prefix" id="prefix"> 

<%if (prefix == "02")
    { %>
   <option value=02 selected>02</option>
<%}
    else
    { %> 
      <option value=02>02</option><%} %>

  <%if (prefix == "04")
      { %>
   <option value=04 selected>04</option>
<%}
    else
    { %> <option value=04 >04</option><%} %>
  <%if (prefix == "03")
      { %>
   <option value=03 selected>03</option>
<%}
    else
    {  %> <option value=03 >03</option> <%} %>
  <%if (prefix == "08")
      { %>
   <option value=08 selected>08</option>
<%}
    else
    { %> <option value=08 >08</option><%} %>
  <%if (prefix == "09")
      { %>
   <option value=09 selected>09</option>
<%}
    else
    {  %> <option value=09 >09</option><%} %>
  <%if (prefix == "077")
      { %>
   <option value=077 selected>077</option>
<%}
    else
    {  %>  <option value=077 >077</option><%} %>
  <%if (prefix == "050")
      { %>
   <option value=050 selected>050</option>
<%}
    else
    {   %>  <option value=050 >050</option><%} %>
  <%if (prefix == "052")
      { %>
   <option value=052 selected>052</option>
<%}
    else
    {  %>  <option value=052 >052</option><%} %>
  <%if (prefix == "053")
      { %>
   <option value=053 selected>053</option>
<%}
    else
    {  %> <option value=053 >053</option><%} %>
  <%if (prefix == "054")
      { %>
   <option value=054 selected>054</option>
<%}
    else
    {  %>  <option value=054 >054</option><%} %>
  <%if (prefix == "055")
      { %>
   <option value=055 selected>055</option>
<%}
    else
    {  %> <option value=055 >055</option><%} %>
  <%if (prefix == "057")
      { %>
   <option value=057 selected>057</option>
<%}

    else
    {  %> <option value=057 >057</option><%} %>
  <%if (prefix == "058")
      { %>
   <option value=058 selected>058</option>
<%}
    else
    { %><option value=058 >058</option><% }%>

        </select>

           <a> &nbsp </a>

          <input type="number"; id="Phone"; name="Phone" value="<%= phone%>" required/>

        </td>

        <td> <input type="text"; id="mPhone"; size="30"; style="display:none; background-color:silver;" disabled="disabled" /> </td>

    </tr>


   <tr>
        <td> City: </td>
                  
       <td>
        <select name="city"> 

           <%= Citystr %>

        </select>

        </td>
        <td> <input type="text"; id="mCity"; size="30"; style="display:none; background-color:silver;" disabled="disabled"/> </td>
    </tr>


    <tr>
        <td> Hobies: </td>

        <td>

    <%if (hob1 == "T")
    { %>
        <input type ="checkbox"; name="hobies"; checked="checked"; value ="Football" /> Football
        &nbsp; 
      <%}
    else
    { %> 
        <input type ="checkbox"; name="hobies"; value ="Football" /> Football
        &nbsp;
     <%} %>


    <%if (hob2 == "T")
{ %>
    <input type = "checkbox"; name="hobies"; value = "Basket Ball"; checked="checked" /> Basket Ball
     &nbsp;
  <%}
else
{ %> 
    <input type = "checkbox"; name="hobies"; value = "Basket Ball" / /> Basket Ball
     &nbsp;
 <%} %>


    <%if (hob3 == "T")
{ %>
    <input type = "checkbox"; name="hobies"; value = "Swimming"; checked="checked" /> Swimming
    &nbsp;
  <%}
else
{ %> 
    <input type = "checkbox"; name="hobies"; value = "Swimming" /> Swimming
    &nbsp;
 <%} %>


    <%if (hob4 == "T")
{ %>
    <input type = "checkbox"; name="hobies"; value = "Programming"; checked="checked" /> Programming
     &nbsp;
  <%}
else
{ %> 
    <input type = "checkbox"; name="hobies"; value = "Programming" /> Programming
    &nbsp;
 <%} %>


    <%if (hob5 == "T")
{ %>
    <input type = "checkbox"; name="hobies"; value = "Video Games"; checked="checked" /> Video Games
    &nbsp;
  <%}
else
{ %> 
    <input type = "checkbox"; name="hobies"; value = "Video Games" /> Video Games
    &nbsp;
 <%} %>


        </td>
        <td> <input type="text"; id="mHobies"; size="30"; style="display:none; background-color:silver;" disabled="disabled"/> </td>

    </tr>


    <tr>
                  <td> Password: </td>
                  <td><input type="password"; id="password"; name="password" value="<%= pass%>" required/></td>
        <td> <input type="text"; id="mPassword"; size="30"; style="display:none; background-color:silver; width:300px;" disabled="disabled" /> </td>
    </tr>


    <tr>
        <td> Confirm Password: </td>
         <td><input type="password"; id="rePassword"; name="rePassword" value="<%= pass%>" required/></td>
    </tr>

        <tr>
            <td>&nbsp;</td>
        </tr>

    <tr>
        <td colspan="3"> <input type="submit"; value="Apply Changes" ; name="submit"; id="submit" /></td>
    </tr>


</table>

</form>

<br />


<h2 style="font-size:xx-large">
      &nbsp;
      <%  Response.Write(msg);  %>
</h2>


</asp:Content>
