using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class Query4 : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";
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
                string tableName = "usersTbl";
                sqlSelect = "SELECT * FROM " + tableName;

                // SQL Select Code!!
                sqlSelect += " where email LIKE '%gmail%' and yearBorn BETWEEN '2000' AND '2007'";


                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                int length = table.Rows.Count;
                if (length == 0) msg = "There are No Registered Users to Show";
                else
                {
                    st += sqlSelect;
                    st += "</br>";

                    st += "<table style=\"border: 1px solid black; margin-top:50px;\">";

                    st += "<tr>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Username</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>first Name</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Last Name</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Email</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Birth Year</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Gender</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Phone Number</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>City</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Football</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Basket Ball</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Swimming</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Programming</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Video Games</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; '>Password</th>";
                    st += "</tr>";
                }
                for (int i = 0; i < length; i++)
                {
                    st += "<tr>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["uName"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["fName"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["lName"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["email"] + "</td > ";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["yearBorn"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["gender"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["prefix"] + table.Rows[i]["phone"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["city"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["hob1"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["hob2"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["hob3"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["hob4"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["hob5"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black; '>" + table.Rows[i]["pass"] + "</td>";
                    st += "</tr>";

                }

                st += "</table>";

                msg = " <h3 style=\"color:deepskyblue; font-size:x-large; font-family:Calibri\"> there are " + length + " registered user/s that use 'Gmail' and were born between 2000 to- 2007 </h3>";

            }

        }
    }
}