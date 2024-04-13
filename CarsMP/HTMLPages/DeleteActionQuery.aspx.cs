using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class DeleteActionQuery : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Admin"].ToString() == "no")
            {
                msg += "<h4 style=\"font-size:28px; color: red; text-align: center;\"> Admin Account is not Active, please Login to Have Acceess! </h3>";
                msg += "<a href='AdminLogin.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Login as Admin</a> <br /> <br />";
                msg += "<a href='Cars.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri;\">Go to Favourite Cars Page</a> <br />";
            }
            else
            {
                string fileName = "usersDB.mdf";

                if ((int)Session["Delete"] != 0)
                {
                    string sqlDelete = "";
                    string Value = "";
                    switch ((int)Session["Delete"])
                    {
                        case 1:
                            Value = Request.QueryString["fName"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE fName LIKE '%" + Value + "%'";
                            break;
                        case 2:
                            Value = Request.QueryString["lName"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE lName LIKE '%" + Value + "%'";
                            break;
                        case 3:
                            Value = Request.QueryString["email"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE email LIKE '%" + Value + "%'";
                            break;
                        case 4:
                            Value = Request.QueryString["yearBorn"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE yearBorn ='" + Value + "'";
                            break;
                        case 5:
                            Value = Request.QueryString["gender"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE gender ='" + Value + "'";
                            break;
                        case 6:
                            Value = Request.QueryString["prefix"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE prefix ='" + Value + "'";
                            break;
                        case 7:
                            Value = Request.QueryString["phone"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE phone LIKE '%" + Value + "%'";
                            break;
                        case 8:
                            Value = Request.QueryString["city"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE city ='" + Value + "'";
                            break;
                        case 9:
                            Value = Request.QueryString["hob1"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE hob1 ='" + Value + "'";
                            break;
                        case 10:
                            Value = Request.QueryString["hob2"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE hob2 ='" + Value + "'";
                            break;
                        case 11:
                            Value = Request.QueryString["hob3"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE hob3 ='" + Value + "'";
                            break;
                        case 12:
                            Value = Request.QueryString["hob4"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE hob4 ='" + Value + "'";
                            break;
                        case 13:
                            Value = Request.QueryString["hob5"].ToString();
                            sqlDelete = "DELETE FROM usersTbl WHERE hob5 ='" + Value + "'";
                            break;
                    }

                    Helper.DoQuery(fileName, sqlDelete);
                    Response.Redirect("AdminControl.aspx");
                }
            }

        }
    }
}