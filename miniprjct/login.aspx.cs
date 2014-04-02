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

public partial class Default4 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IL10;Initial Catalog=Mobile Service;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();
    Class1 ob=new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
    }
            
    
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string x = txtuser.Text.ToString();
        string y = txtpswd.Text.ToString();
        string g = "select usertype from login1 where username='" + x + "'and password='" + y + "'";
        string type = ob.log(g);
        if (type == "user")
        {
            Session["user"] = txtuser.Text.ToString();
            Server.Transfer("profile.aspx");
        }
        else if (type == "admin")
        {
            Server.Transfer("admin_login.aspx");
        }
        else
        {
            Label3.Visible = true;
            Label3.Text = "Incorrect Username and password";
        }
        
    }
 
 
}
       