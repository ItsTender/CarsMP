using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsMP.HTMLPages
{
    public partial class AdminDeleteUsersQuery : System.Web.UI.Page
    {
        public string sql = "";
        public string msg = "";
        public string stdelete = "";
        public string st = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"].ToString() == "no")
            {
                st += "<h4 style=\"font-size:28px; color: red; text-align: center;\"> Admin Account is not Active, please Login to Have Acceess! </h3>";
                st += "<a href='AdminLogin.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Login as Admin</a> <br /> <br />";
                st += "<a href='Cars.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri;\">Go to Favourite Cars Page</a> <br />";
            }
            else
            {

                st += "<h2 style=\"font-size:50px; margin-top:50px;\">Search and Delete Users</h2>\r\n";
                st += "<form method=\"post\" runat=\"server\" style=\"text-align:center;\">\r\n    <select name=\"field\"; id=\"field\"; onclick=\"DetectField();\">\r\n        <option>Choose :</option>\r\n        <option value=\"fName\">First Name</option>\r\n        <option value=\"lName\">Last Name</option>\r\n        <option value=\"email\">Email</option>\r\n        <option value=\"yearBorn\">Year Born</option>\r\n        <option value=\"gender\">Gender</option>\r\n        <option value=\"prefix\">Prefix</option>\r\n        <option value=\"phone\">Phone</option>\r\n        <option value=\"city\">City</option>\r\n        <option value=\"hobby\">Hobby</option>\r\n    </select>\r\n    <br />\r\n    <div id=\"query\"></div>\r\n    <br />\r\n    <input type=\"submit\" name=\"submit\" value=\"Search\" />\r\n</form> <br />";

                string hob = "";
                // وضع اسم الحقل و قيمة الحقل في متغيرات
                string field = Request.Form["field"];
                string value = Request.Form["value"];

                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";
                string sqlSelect = "";

                if (Request.Form["submit"] != null)
                {
                    if (field == "yearBorn" || field == "gender" || field == "prefix" || field == "city")
                    {
                        sqlSelect = "SELECT * FROM " + tableName + " where (" + field + " = '" + value + "');";
                        st += "How many users have " + value + " in their " + field;
                        if (field == "yearBorn")
                            Session["Delete"] = 4;
                        else if (field == "gender")
                            Session["Delete"] = 5;
                        else if (field == "prefix")
                            Session["Delete"] = 6;
                        else if (field == "city")
                            Session["Delete"] = 8;

                        stdelete = "<a href = 'DeleteActionQuery.aspx?" + field + "=" + value + "' style= 'color: red' >[Delete]</a>";
                    }
                    else
                    {
                        if (field == "hobby")
                        {
                            if (value.Equals("1") || value.Equals("2") || value.Equals("3") || value.Equals("4") || value.Equals("5"))
                            {
                                var val = int.Parse(value);
                                switch (val)
                                {
                                    case 1:
                                        field = "hob1"; Session["Delete"] = 9;
                                        hob = "Football"; break;
                                    case 2:
                                        field = "hob2"; Session["Delete"] = 10;
                                        hob = "Basket Ball"; break;
                                    case 3:
                                        field = "hob3"; Session["Delete"] = 11;
                                        hob = "Swimming"; break;
                                    case 4:
                                        field = "hob4"; Session["Delete"] = 12;
                                        hob = "Programming"; break;
                                    case 5:
                                        field = "hob5"; Session["Delete"] = 13;
                                        hob = "Video Games"; break;
                                }
                                sqlSelect = "SELECT * FROM " + tableName + " where (" + field + " = 'T');";
                                st += "How many users have " + hob + " as their Hobby";
                                stdelete = "<a href = 'DeleteActionQuery.aspx?" + field + "='T'' style= 'color: red' >[Delete]</a>";
                            }
                        }
                        else
                        {
                            sqlSelect = "SELECT * FROM " + tableName + " where (" + field + " like '%" + value + "%');";
                            st += "How many users have " + value + " in their " + field;
                            if (field == "fName")
                                Session["Delete"] = 1;
                            else if (field == "lName")
                                Session["Delete"] = 2;
                            else if (field == "email")
                                Session["Delete"] = 3;
                            else if (field == "phone")
                                Session["Delete"] = 7;

                            stdelete = "<a href = 'DeleteActionQuery.aspx?" + field + "=" + value + "' style= 'color: red' >[Delete]</a>";

                        }

                    }

                    DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                    int length = table.Rows.Count;
                    if (length == 0)
                    {
                        msg = "There are no users with the selected attribute";
                    }
                    else
                    {

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
                        msg = "There are " + length + " users that have this attribute";

                    }
                }
            }

        }
    }
}