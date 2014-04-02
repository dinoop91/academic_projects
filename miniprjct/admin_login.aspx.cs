using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IL10;Initial Catalog=Mobile Service;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("mobile_details.aspx");
    }
}
