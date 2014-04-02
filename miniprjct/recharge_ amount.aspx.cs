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
    Class1 obj3 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string bind = "select operator from operator";
            SqlDataReader dr = obj3.Reader(bind);
            DropDownList1.DataSource = dr;

            DropDownList1.DataTextField = "operator";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "-select-");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ins = "insert into rchgcpn values('" + DropDownList1.SelectedItem.Text + "','" + txtamount.Text + "','" + txttalk.Text + "','" + txtvalidity.Text + "')";
        obj3.query(ins);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string upd = "update rchgcpn set amount='" + txtamount.Text + "',talk='" + txttalk.Text + "' where operator='" + DropDownList1.SelectedItem.Text + "'";
        obj3.query(upd);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string del = "delete  from rchgcpn where operator='" + DropDownList1.SelectedItem.Text + "'";
        obj3.query(del);
    }
 
  
    
}
