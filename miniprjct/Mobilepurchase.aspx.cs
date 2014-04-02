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
    Class1 obj6 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string bind2 = "select distinct company from mobdet ";
            SqlDataReader dr = obj6.Reader(bind2);
            drpcompany.DataSource = dr;
            drpcompany.DataTextField = "company";
            drpcompany.DataBind();
            drpcompany.Items.Insert(0, "-select-");
        }

    }
   protected void drpcompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
 
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("purchase_payment.aspx?model=" + e.CommandArgument);
    }


    protected void drpcompany_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string data = "select image,model,price,feature from mobdet where company='" + drpcompany.SelectedItem.Text + "'";
        SqlDataReader dr = obj6.Reader(data);
        DataList1.DataSource = dr;
        DataList1.DataBind();
        Session["comp"] = drpcompany.Text;
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
