using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (
                 // Creating Connection  
                 SqlConnection con = new SqlConnection("data source=(LocalDb)\\MSSQLLocalDB; database=aspnet-MVCPractice-20240320034311; integrated security=SSPI")
             )
            {
                SqlCommand cmd = new SqlCommand("select * from products",con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();
            }
        }
    }
}