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
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=CGI-JAVA-185\\MSSQLSERVER1;Initial Catalog=Sample08;Integrated Security=true";
            con1.Open();
            string query1 = "insert into Users (Email_Id,Passwrd,Names,Phoneno,Addres,Roles) values(@Eid,@Pass,@Name,@phone,@addres,@Roles)";

            SqlCommand cmd = new SqlCommand(query1, con1);
            cmd.Parameters.AddWithValue("@Eid",TextBox1.Text);
            cmd.Parameters.AddWithValue("@Pass",TextBox2.Text);
            cmd.Parameters.AddWithValue("@Name",TextBox3.Text);
            cmd.Parameters.AddWithValue("@phone",TextBox4.Text);
            cmd.Parameters.AddWithValue("@addres", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Roles", "User");
            try
            {
                cmd.ExecuteNonQuery();
                Response.Redirect("~/Login.aspx");

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}