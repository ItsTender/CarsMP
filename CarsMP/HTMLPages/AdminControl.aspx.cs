using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class AdminControl : System.Web.UI.Page
    {

        public string msg = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"].ToString() == "no")
            {
                msg += "<h4 style=\"font-size:28px; color: red; text-align: center;\"> Admin Account is not Active, please Login to Have Acceess! </h3>";
                msg += "<a href='AdminLogin.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Login as Admin</a> <br /> <br />";
                msg += "<a href='Cars.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri;\">Go to Favourite Cars Page</a> <br />";
            }
            else
            {

                msg += "<a href='AdminShowUsers.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Show All Users</a> <br />";
                msg += "<a href='AdminDeleteUsers' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Delete Users</a> <br /><br />";
                msg += "<a href='Query1.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Show all Users that have the letter 'a' in their First Names</a> <br />";
                msg += "<a href='Query2.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Show all Users that have the letter 's' in their Last Names</a> <br />";
                msg += "<a href='Query3.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Show all Users that use 'Gmail' and live in Nazareth, Jerusalem or Tel Aviv</a> <br />";
                msg += "<a href='Query4.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Show all Users that use 'Gmail' and were born between 2000 to- 2007</a> <br />";

            }

        }
    }
}