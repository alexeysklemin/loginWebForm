using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1
{
    public partial class loginForm : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection ("Data Source=LAPTOP-ALEX\\SQLEXPRESS;Initial Catalog=emloees;Integrated Security=True");
        //Data Source=laptop-alex\sqlexpress;Initial Catalog=emloees;Integrated Security=True
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM loginTable WHERE account='"+ txtuser.Text + "'AND passsword="+ txtPswd+'"',conn);
            DataTable DaTab = new DataTable();
             sqlDataAdapter.Fill(DaTab);

            if (DaTab.Rows.Count > 0)
            {
                Label1.Text = "You successfuly login to the system";
            }
            else
            {
                Label1.Text = "Invalid UserName or password";
            }
        }
    }
}