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
    public partial class check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAOClass n = new DAOClass();
            SqlDataAdapter sd = null;
            string n1 = TextBox1.Text;
            DataSet p = n.check(n1);
           // sd.Fill(p);
            GridView1.DataSource = p;
            GridView1.DataBind();

        }
    }
}