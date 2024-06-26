﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CarsMP.HTMLPages
{
    public partial class EditUserInfo : System.Web.UI.Page
    {
        public string msg = "";
        public string sqlMsg = "";
        public string sqlSelect = "";
        public string UpdatedInfo = "";
        public string Citystr = "";
        public string yrBorn = "";
        public string uName, fName, lName, email, gender, phone, prefix, pass;
        public string yearBorn, city, hob1, hob2, hob3, hob4, hob5;

        protected void Page_Load(object sender, EventArgs e)
        {

            string fileName = "usersDB.mdf";

            if (Session["uName"].ToString() == "Guest" || Session["admin"].ToString() == "yes")
            {
                msg += "<a>Only Registered users can edit their profile info!</a> <br/><br/>";
                msg += "<a href='Login.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Login with your Account</a> <br /> <br />";
                msg += "<a href='Cars.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri;\">Go to Favourite Cars Page</a> <br />";
            }
            else
            {
                uName = Session["uName"].ToString();

                sqlSelect = "SELECT * FROM usersTbl WHERE uName= '" + uName + "'";
                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);
                sqlMsg = sqlSelect;


                int length = table.Rows.Count;
                if (length == 0)
                {
                    msg += "<a>You are not Registered to the Website</a> <br/><br/>";
                    msg += "<a href='Login.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri\">Login with your Account</a> <br /> <br />";
                    msg += "<a href='Cars.aspx' style=\"color:deepskyblue; font-size:xx-large; font-family:Calibri;\">Go to Favourite Cars Page</a> <br />";
                }
                else
                {

                    // PreSelecting............
                    fName = table.Rows[0]["fName"].ToString().Trim();
                    lName = table.Rows[0]["lName"].ToString().Trim();
                    email = table.Rows[0]["email"].ToString().Trim();
                    prefix = table.Rows[0]["prefix"].ToString().Trim();
                    phone = table.Rows[0]["phone"].ToString().Trim();
                    gender = table.Rows[0]["gender"].ToString();
                    city = table.Rows[0]["city"].ToString().Trim();
                    hob1 = table.Rows[0]["hob1"].ToString().Trim();
                    hob2 = table.Rows[0]["hob2"].ToString().Trim();
                    hob3 = table.Rows[0]["hob3"].ToString().Trim();
                    hob4 = table.Rows[0]["hob4"].ToString().Trim();
                    hob5 = table.Rows[0]["hob5"].ToString().Trim();

                    int yBorn = Convert.ToInt16(table.Rows[0]["yearBorn"].ToString().Trim());

                    pass = table.Rows[0]["pass"].ToString().Trim();


                    // PreSelecting............
                    int year = DateTime.Now.Year;
                    int from = year - 60;
                    int to = year - 10;
                    for (int i = from; i <= to; i++)
                    {

                        if (i == yBorn)
                            yrBorn += $"<option value = '{i}' selected> {i} </option>";
                        else
                            yrBorn += "<option value = '" + i + "'>" + i + "</option>";

                    }

                    // PreSelecting............
                    string[] cities = { "Nazareth", "Safed", "Afula", "Haifa", "Tiberias", "Karmiel", "Acre", "Netanya", "Nablus", "Tel Aviv",
                     "Ramallah", "Jerusalem", "Ashkelon", "Gaza", "Beer Sheva", "Eilat" };

                    for (int i = 0; i < cities.Length; i++)
                    {
                        if (cities[i] == city)
                            Citystr += $"<option value ='{cities[i]}' selected>{cities[i]}</option>";
                        else
                            Citystr += $"<option value ='{cities[i]}'>{cities[i]}</option>";
                    }


                    if (this.IsPostBack)
                    {
                        fName = Request.Form["firstName"];
                        lName = Request.Form["lastName"];
                        email = Request.Form["email"];
                        city = Request.Form["city"];
                        prefix = Request.Form["prefix"];
                        phone = Request.Form["Phone"];
                        gender = Request.Form["gender"];
                        yearBorn = Request.Form["year"];
                        pass = Request.Form["password"];

                        String Hobies = Request.Form["hobies"];
                        char ch1 = 'F', ch2 = 'F', ch3 = 'F', ch4 = 'F', ch5 = 'F';

                        if (Hobies != null)
                        {
                            if (Hobies.Contains("Football")) ch1 = 'T';
                            if (Hobies.Contains("Basket Ball")) ch2 = 'T';
                            if (Hobies.Contains("Swimming")) ch3 = 'T';
                            if (Hobies.Contains("Programming")) ch4 = 'T';
                            if (Hobies.Contains("Video Games")) ch5 = 'T';
                        }


                        // Updating the newly entered User Info!!
                        UpdatedInfo = "UPDATE usersTbl ";
                        UpdatedInfo += "SET fName = '" + fName + "', ";
                        UpdatedInfo += "lName = '" + lName + "', ";
                        UpdatedInfo += "email = '" + email + "', ";
                        UpdatedInfo += "yearBorn = '" + yearBorn + "', ";
                        UpdatedInfo += "gender = '" + gender + "', ";
                        UpdatedInfo += "prefix = '" + prefix + "', ";
                        UpdatedInfo += "phone = '" + phone + "', ";
                        UpdatedInfo += "city = '" + city + "', ";
                        UpdatedInfo += "hob1 = '" + ch1 + "', ";
                        UpdatedInfo += "hob2 = '" + ch2 + "', ";
                        UpdatedInfo += "hob3 = '" + ch3 + "', ";
                        UpdatedInfo += "hob4 = '" + ch4 + "', ";
                        UpdatedInfo += "hob5 = '" + ch5 + "', ";

                        UpdatedInfo += "pass = '" + pass + "' ";
                        UpdatedInfo += "WHERE uName = '" + uName + "'";


                        Helper.DoQuery(fileName, UpdatedInfo);

                        msg = "Successfully Updated your User Info";
                    }
                }
            }

        }
    }
}