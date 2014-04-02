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
    
    Class1 obj = new Class1();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        DataList1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        string  url = "~/image/" + FileUpload1.FileName;
        FileUpload1.PostedFile.SaveAs(MapPath(url));
        Image1.ImageUrl = url;
      
         string  s="insert into mobdet values('" +url+ "','" + DropDownList1.SelectedItem.Text + "','" + modeltxt.Text + "','" + featuretxt.Text + "','" + pricetxt.Text + "','" + counttxt.Text + "')";
         obj.query(s);
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataList1.Visible = true;
        string adpt = "select * from mobdet";
        SqlDataReader dr = obj.Reader(adpt);
        DataList1.DataSource = dr ;
        DataList1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string  u = "update mobdet set feature='" + featuretxt.Text + "',Price='" + pricetxt.Text + "',Count='" + counttxt.Text + "' where company='"+DropDownList1.SelectedItem.Text+"',model='"+modeltxt.Text+"'";
        obj.query(u);

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string  d = "delete mobdet where feature='" +featuretxt.Text + "'";
        obj.query(d);
    }


 
   
}

