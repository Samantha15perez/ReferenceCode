using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Resume_Website_Project
{
    public partial class Sandbox : System.Web.UI.Page
    {
        bool IspersonLoggedin = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                string connectionString = null;
                SqlConnection cnn;
                connectionString = @"Server=DTPLAPTOP05;Database=SandboxLoginTest;Trusted_Connection=True;";
                cnn = new SqlConnection(connectionString);
                try
                {

                    SqlDataAdapter SQLDA = new SqlDataAdapter("dbo.PasswordCheck", connectionString);
                    DataTable dtPasswordCheck = new DataTable();
                    SQLDA.Fill(dtPasswordCheck);

                    DataRow[] PasswordDR = dtPasswordCheck.Select("Username = '" + TextBox1.Text + "'");

                    if (PasswordDR.Any())
                    {
                        if (PasswordDR[0].ItemArray[1].ToString() == TextBox2.Text)
                        {
                            Response.Write("Congratulations! You won nothing! :)");
                            IspersonLoggedin = true;
                        }
                        else
                        {
                            Response.Write("Password was incorrect.");
                        }
                    }
                    else
                    {
                        Response.Write("Username was incorrect.");
                    }
                    

                }catch
                {
                    Response.Write("Attempt Failed: Unable to connect to SQL database.");

                }

                if (IspersonLoggedin == true)
                {
                    
                }
            }
        }
    }
}