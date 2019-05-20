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
    public partial class DashBoard : System.Web.UI.Page
    {
        string Name = null;
        string name1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                name1 = Session["userid"].ToString();
                Console.WriteLine(name1);

            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "Data Source=CGI-JAVA-185\\MSSQLSERVER1;Initial Catalog=Sample08;Integrated Security=true";
            con2.Open();
            string query2 = "select l.Requested_Amount,u.Roles,l.L_Id ,l.Loan_Description ,l.RequestStatus  from Loan_Request l, Users u where u.u_Id=l.Assinged_To AND l.Requested_For ="+ name1;
            SqlCommand cmd = new SqlCommand(query2, con2);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            con2.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            

            if (Application["User_Id"] != null)
            {
                 Name = Application["User_Id"].ToString();
                Response.Write(Name);
            }
            Application["User_Id"] = Name;
            Response.Redirect("Loan_Request.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}