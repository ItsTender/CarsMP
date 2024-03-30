using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;

namespace CarsMP.HTMLPages
{
    public partial class Register : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public String yrBorn = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Form["submit"] != null)
            {

                String UName = Request.Form["Username"].ToString();
                String FName = Request.Form["FirstName"].ToString();
                String LName = Request.Form["LastName"].ToString();
                String Email = Request.Form["Email"].Trim().ToString();
                String Year = Request.Form["Year"].ToString();
                String Phone = Request.Form["Phone"].ToString();
                String Prefix = Request.Form["prefix"].ToString();
                String Gender = Request.Form["gender"].ToString();
                String City = Request.Form["city"].ToString();
                String Pass = Request.Form["password"].ToString();
                String ConfPass = Request.Form["rePassword"].ToString();
                String Hobies = Request.Form["hobies"];

                //تحويل سنة الولادة كعدد
                int yearB = int.Parse(Year);

                //فحص الهوايات وتحويلها لصدق او كذب
                char ch1 = 'F', ch2 = 'F', ch3 = 'F', ch4 = 'F', ch5 = 'F';

                if (Hobies != null)
                {
                    if (Hobies.Contains("Football")) ch1 = 'T';
                    if (Hobies.Contains("Basket Ball")) ch2 = 'T';
                    if (Hobies.Contains("Swimming")) ch3 = 'T';
                    if (Hobies.Contains("Programming")) ch4 = 'T';
                    if (Hobies.Contains("Video Games")) ch5 = 'T';
                }

                //ربط لقاعدة البيانات
                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";

                //فحص اذا كان اسم المستخدم مستعمل بقاعدة البيانات
                string sqlSelect = "SELECT * FROM " + tableName + " WHERE uName ='" + UName + "'";
                string sqlInsert;

                if (Helper.IsExist(fileName, sqlSelect))
                {
                    msg = "The Username has Already been taken";
                }
                else
                {
                    sqlInsert = "INSERT INTO usersTbl";
                    sqlInsert += " VALUES ('" + UName + "','" + FName + "','" + LName + "','" + Email + "','" + yearB + "','";
                    sqlInsert += Gender + "','" + Prefix + "','" + Phone + "','" + City + "','";
                    sqlInsert += ch1 + "','" + ch2 + "','" + ch3 + "','" + ch4 + "','" + ch5 + "','" + Pass + "')";
                    Helper.DoQuery(fileName, sqlInsert);


                    st = "<table border='1' align = 'center' dir='ltr'>";
                    st += "<tr><th colspan='2'> recived info </th></tr>";

                    st += "<tr><td>user name:</td><td>" + UName + "</td></tr>";

                    st += $"<tr><td>first name:</td><td>{FName}</td></tr>";
                    st += $"<tr><td>last name:</td><td>{LName}</td></tr>";
                    st += $"<tr><td>email:</td><td>{Email}</td></tr>";
                    st += $"<tr><td>yearBorn:</td><td>{Year}</td></tr>";
                    st += $"<tr><td>gender:</td><td>{Gender}</td></tr>";
                    st += $"<tr><td>phoneNum:</td><td>{Prefix} - {Phone}</td></tr>";


                    st += $"<tr><td>city:</td><td>{City}</td></tr>";
                    st += $"<tr><td>hobies:</td><td> {Hobies}</td></tr>";
                    st += $"<tr><td>pw:</td><td>{Pass}</td></tr>";
                    st += "</table>";

                    msg = "Successfully Signed Up to my Website!";

                }

            }

            int year = DateTime.Now.Year;
            int from = year - 60;
            int to = year - 10;
            for (int i = from; i <= to; i++)
            {

                yrBorn += "<option value='" + i + "'>" + i + " </option>";

            }
        }
    }
}