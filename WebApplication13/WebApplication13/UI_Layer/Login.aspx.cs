using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Model;
using DAOLIbrary;

namespace WebApplication13
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=CGI-JAVA-185\\MSSQLSERVER1;Initial Catalog=Sample08;Integrated Security=true";
            con1.Open();
            string query1 = "select * from Users where Email_Id=@Email and Passwrd=@pass";
            SqlCommand cmd = new SqlCommand(query1, con1);
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            try
            {
               SqlDataReader dr= cmd.ExecuteReader();
                if(dr.Read())
                {
                    u.U_Id1 = Convert.ToInt32(dr[0]);
                    u.Email_Id1 = dr[1].ToString();
                    u.Passwrd1 = dr[2].ToString();
                    u.Roles1 = dr[3].ToString();
                    u.Names1 = dr[4].ToString();
                    u.Phoneno1 = dr[5].ToString();
                    u.Addres1 = dr[6].ToString();
                    if (u.Roles1 == "User")
                    {
                        Session["userid"] = u.U_Id1;
                        Response.Redirect("DashBoard.aspx");
                    }
                    if (u.Roles1 == "officer")
                    {
                       // Session["userid"] = u.U_Id1;
                        Response.Redirect("~/officer.aspx?id=" + u.U_Id1);
                    }
                    if (u.Roles1 == "inspector")
                    {
                       // Session["userid"] = u.U_Id1;
                        Response.Redirect("~/inspector.aspx?id=" + u.U_Id1);
                    }
                    if (u.Roles1 == "Authorizer")
                        Response.Redirect("~/Authorizer.aspx?id=" + u.U_Id1);

                }
                
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
    }
}