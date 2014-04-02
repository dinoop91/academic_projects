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
    Class1 objct = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
       username.Text = Session["user"].ToString();
        if(!IsPostBack)
        {
        string sel = "select * from register where username='" + username.Text + "'";
        SqlDataReader dr = objct.Reader(sel);
        while (dr.Read())
        {
            txtname.Text = dr[0].ToString();
            txtgender.Text = dr[2].ToString();
            txtdob.Text = dr[3].ToString();
            txthname.Text = dr[4].ToString();
            txtplace.Text = dr[5].ToString();
            txtpin.Text = dr[6].ToString();
            txtmobno.Text = dr[7].ToString();
        }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string upd = "update register set name='" + txtname.Text + "',gender='" + txtgender.Text + "',dob='" + txtdob.Text + "',hname='" + txthname.Text + "',place='" + txtplace.Text + "',pin='" + txtpin.Text + "', mobno='" + txtmobno.Text + "' where username='" + username.Text + "'";
        objct.query(upd);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string del = "delete  from register  where username='" +username.Text + "'";
        objct.query(del);
        string del1 = "delete  from login1 where username='" + username.Text + "'";
        objct.query(del1);
    }
}
