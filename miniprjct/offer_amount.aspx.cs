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
    Class1 obj4 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            string bind = "select operator from operator";
            SqlDataReader dr = obj4.Reader(bind);
            drpoper.DataSource = dr;

            drpoper.DataTextField = "operator";
            drpoper.DataBind();
            drpoper.Items.Insert(0, "-select-");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string offer = "insert into offer values('" + drpoper.SelectedItem.Text + "','" + txtamount.Text + "','" + txttalk.Text + "','" + txtvalidity.Text + "')";
        obj4.query(offer);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string upd = "update offer set talk='" + txttalk.Text + "',validity='" + txtvalidity.Text + "' where amount='" + txtamount.Text + "'";
        obj4.query(upd);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string del = "delete from offer where amount='" + txtamount.Text + "'";
        obj4.query(del);
    }
    protected void drpoper_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void txttalk_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtvalidity_TextChanged(object sender, EventArgs e)
    {

    }
}
