using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class DeleteAction : System.Web.UI.Page
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
                string fileName = "usersDB.mdf";
                string uName = Request.QueryString["uName"].ToString();

                string sqlDelete = "DELETE FROM usersTbl WHERE uName ='" + uName + "'";

                Helper.DoQuery(fileName, sqlDelete);
                Response.Redirect("AdminDeleteUsers.aspx");
            }

        }
    }
}