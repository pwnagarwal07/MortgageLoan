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
    public partial class Loan_Details1 : System.Web.UI.Page
    {
        string Name;
        
        protected void Page_Load(object sender, EventArgs e)
        {     
            if (Session["userid"] != null)
            {
                Name = Session["userid"].ToString();
                if (Session["userid"] != null)
                {
                    Name = Session["userid"].ToString();
                }

                TextBox1.Text = Name;
            }

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "Data Source=CGI-JAVA-185\\MSSQLSERVER1;Initial Catalog=Sample08;Integrated Security=true";
                con1.Open();
                string query1 = "select Email_Id from Users where U_Id=@uid";
                SqlCommand cmd = new SqlCommand(query1, con1);
                cmd.Parameters.AddWithValue("@uid", Name);
                try
                {
                    Console.WriteLine("hello");
                    TextBox4.Text = (string)cmd.ExecuteScalar();
                    con1.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "Data Source=CGI-JAVA-185\\MSSQLSERVER1;Initial Catalog=Sample08;Integrated Security=true";
            con2.Open();
            string query2 = "insert into Loan_Request (Requested_For,Assinged_To,Requested_Amount,RequestStatus,Loan_Description,Email_Id) values(@Requested_For,@Assinged_To,@Requested_Amount,@RequestStatus,@Loan_Description,@Email_Id)";
            SqlCommand cmd = new SqlCommand(query2, con2);
            cmd.Parameters.AddWithValue("@Requested_For",TextBox1.Text);
            cmd.Parameters.AddWithValue("@Assinged_To ", 2);
            cmd.Parameters.AddWithValue("@Requested_Amount",TextBox2.Text);
            cmd.Parameters.AddWithValue("@RequestStatus","Reqst");  
            cmd.Parameters.AddWithValue("@Loan_Description",TextBox3.Text);
            cmd.Parameters.AddWithValue("@Email_Id",TextBox4.Text);
            try
            {
                cmd.ExecuteNonQuery();
               Session["userid"] = Name;
                Response.Redirect("DashBoard.aspx");
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}