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
    Class1 obj7 = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {

        Image2.Visible = false;
        Image3.Visible = false;
        rchg.Visible = false;
        offer.Visible = false;
        
        if (!IsPostBack)
        {
            string binds = "select operator from operator";
            SqlDataReader dr = obj7.Reader(binds);
            drpoper.DataSource = dr;
            drpoper.DataTextField = "operator";
            drpoper.DataBind();
            drpoper.Items.Insert(0, "-select-");
        }
    
    }
   
  
    //protected void drpoper_SelectedIndexChanged(object sender, EventArgs e)
    //{
       

    //}
 
    protected void Button1_Click1(object sender, EventArgs e)
    {
      
    }
    protected void drpoper_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Image2.Visible = true;
        Image3.Visible = true;
        rchg.Visible = true; ;
        offer.Visible = true; ;
        string grid1 = "select * from rchgcpn where operator='" + drpoper.SelectedItem.Text + "'";
        SqlDataReader ds = obj7.Reader(grid1);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        string grid2 = "select * from offer where operator='" + drpoper.SelectedItem.Text + "'";
        SqlDataReader ds1 = obj7.Reader(grid2);
        GridView2.DataSource = ds1;
        GridView2.DataBind();
        Session["op"] = drpoper.Text.ToString();
      
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string te = txtamount.Text;
        Response.Redirect("rechgpayment.aspx?id=" + te);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }
}
