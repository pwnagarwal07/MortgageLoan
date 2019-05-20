using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAOLIbrary
{
   public  class DAOClass
    {
        MyConnection myCon;
        SqlConnection sqlCon;
        public DAOClass()
        {
            sqlCon = new SqlConnection();
            myCon = new MyConnection();
        }
        public  DataSet check(string input)
        {
           
            sqlCon = myCon.getConnection();
            sqlCon.Open();
            String query1 = "select l.Requested_Amount,u.Roles,l.L_Id ,l.Loan_Description ,l.RequestStatus  from Loan_Request l, Users u where u.u_Id=l.Assinged_To AND l.Email_Id =@Empid";
            SqlCommand cmd = new SqlCommand(query1, sqlCon);
            cmd.Parameters.AddWithValue("@Empid", input);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
           sd.Fill(ds);
            return ds;
          // GridView1.DataSource = ds;
           // GridView1.DataBind();
        }
    }
}
