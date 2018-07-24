using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Resume_Website_Project
{
    public partial class Sandbox : System.Web.UI.Page
    {
        
     

        protected void Page_Load(object sender, EventArgs e)
        {
            
           if (Session["UserName"] != null && Session["UserName"] != "")
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
           else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }

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
                Session["UserName"] = "NotLoggedIn";

                string connectionString = null;
                SqlConnection cnn;
                
                connectionString = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                cnn = new SqlConnection(connectionString);
                try
                {

                    SqlDataAdapter SQLDA = new SqlDataAdapter("dbo.PasswordCheck", connectionString);
                    DataTable dtPasswordCheck = new DataTable();
                    SQLDA.Fill(dtPasswordCheck);

                    DataRow[] PasswordDR = dtPasswordCheck.Select("Username = '" + TextBox1.Text + "'");

                    // step 1, calculate MD5 hash from input

                    string InputValue = TextBox2.Text.ToString();
                    MD5 EncryptionHash = System.Security.Cryptography.MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(InputValue);
                    byte[] hash = EncryptionHash.ComputeHash(inputBytes);

                    // step 2, convert byte array to hex string

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }


                    


                    if (PasswordDR.Any())
                    {
                        if (PasswordDR[0].ItemArray[1].ToString() == sb.ToString())
                        {
                            Response.Write("Welcome " + TextBox1.Text + "!");
                            Session["UserName"] = TextBox1.Text;

                            
                        
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

                
            }
            if (Session["UserName"].ToString() != null)
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                }
                if (Session["UserName"].ToString() == null)
            {
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                }
        }
    }
}