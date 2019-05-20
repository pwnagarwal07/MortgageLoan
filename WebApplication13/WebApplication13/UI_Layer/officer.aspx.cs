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
    public partial class officer : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {

                //SqlConnection con1 = new SqlConnection();
                //con1.ConnectionString = "Data Source=LAPTOP-UDCMP7EJ\\SQLEXPRESS1;Initial Catalog=Sample08;Integrated Security=true";
                //con1.Open();
                //string query = "Select * from Loan_Request where RequestStatus=@Result";
                //SqlCommand cmd = new SqlCommand(query, con1);
                //cmd.Parameters.AddWithValue("@Result", "Reqst");
                //SqlConnection con2 = new SqlConnection();
                // con2.ConnectionString = "Data Source=LAPTOP-UDCMP7EJ\\SQLEXPRESS1;Initial Catalog=Sample08;Integrated Security=true";
                // con2.Open();
                //  string query1 = "Select * from Loan_Request where RequestStatus=@Result2";
                // SqlCommand cmd1 = new SqlCommand(query1, con2);
                // cmd.Parameters.AddWithValue("@Result2", "Assesd");
                // SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                // DataSet ds1 = new DataSet();
                //sda1.Fill(ds1);
                // GridView2.DataSource = ds1;
                // GridView2.DataBind();        
            }
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}