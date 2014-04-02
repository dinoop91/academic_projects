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
    Class1 ob2 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["user"].ToString();
    }
    
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
        Session["user"] = null;
    }

  
  

    

}
