using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class AdminLogin : System.Web.UI.Page
    {

        public string Login = "";
        public string msg = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Form["submit"] != null)
            {

                string uName = Request.Form["Username"];
                string pw = Request.Form["password"];

                string fileName = "usersDB.mdf";
                string tableName = "adminsTbl";

                Login = $"SELECT * from {tableName} where uName = '{uName}' and pw = '{pw}'";

                DataTable table = Helper.ExecuteDataTable(fileName, Login);
                int length = table.Rows.Count;
                if (length == 0)
                {
                    msg = "Username has yet to be Registered!";
                }
                else
                {

                    Application.UnLock();

                    Session["admin"] = "yes";
                    Session["uName"] = table.Rows[0]["uName"];
                    Session["userFName"] = "Admin";

                    Response.Redirect("AdminControl.aspx");

                }

            }

        }
    }
}