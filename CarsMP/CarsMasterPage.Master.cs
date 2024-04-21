using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP
{
    public partial class CarsMasterPage : System.Web.UI.MasterPage
    {
        public string UserOptions = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userFName"].ToString() != "Guest")
            {

                UserOptions = "<a style=\"color:black; font-size:xx-large; font-family:Calibri; font-style:oblique; font-weight:800\"> Hello, ";
                UserOptions += Session["userFName"].ToString();
                UserOptions += "<a> <br /> <br />";


                if(Session["admin"].ToString() == "no") UserOptions += "<a href='EditUserInfo.aspx' style=\"color:deepskyblue; font-size:x-large; font-family:Calibri\">Edit Profile</a> <br />";
                else UserOptions += "<a href='AdminControl.aspx' style=\"color:deepskyblue; font-size:x-large; font-family:Calibri\">Admin Page</a> <br />";

                UserOptions += "<a href='Logout.aspx' style=\"color:deepskyblue; font-size:x-large; font-family:Calibri\">Logout</a>";

            }
            else {

                UserOptions = "<a style=\"color:black; font-size:xx-large; font-family:Calibri; font-style:oblique; font-weight:800\"> Hello, Guest ";
                UserOptions += "<a> <br /> <br />";

                UserOptions += "<a href=\"Register.aspx\" style=\"color:deepskyblue; font-size:x-large; font-family:Calibri\"> Create new account </a> <br />";
                UserOptions += "<a href=\"Login.aspx\" style=\"color:deepskyblue; font-size:x-large; font-family:Calibri\"> Login with account </a>";

            }

        }
    }
}