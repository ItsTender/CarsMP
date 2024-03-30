using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class Login : System.Web.UI.Page
    {

        public string login = "";
        public string msg = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Form["submit"] != null)
            {

                string uName = Request.Form["Username"];
                string pw = Request.Form["password"];

                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";

                login = $"SELECT * from {tableName} where uName = '{uName}' and pass = '{pw}'";

                DataTable table = Helper.ExecuteDataTable(fileName, login);
                int length = table.Rows.Count;
                if (length == 0)
                    msg = "Username has yet to be Registered!";
                else
                {

                    Application.Lock();

                    // Increase the Login Counter by one!
                    if (Application["counter"] == null) Application["counter"] = 1;
                    else Application["counter"] = (int)Application["counter"] + 1;

                    Application.UnLock();


                    // Bind the current logged in user info.
                    Session["uName"] = table.Rows[0]["uName"];
                    Session["userFName"] = table.Rows[0]["fName"];

                    Response.Redirect("Cars.aspx");
                }

            }

        }
    }
}