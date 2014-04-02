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
    
    Class1 ob1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   

    protected void Button1_Click(object sender, EventArgs e)
    {
        string url = "~/image/" + FileUpload1.FileName;
        FileUpload1.PostedFile.SaveAs(MapPath(url));
        Image1.ImageUrl=url;
        string op = "insert into operator values('"+url +"','" + DropDownList1.SelectedItem.Text + "','" + txttot.Text + "')";
        ob1.query(op);
    }
   
    protected void Button5_Click(object sender, EventArgs e)
    {
        string upd = "delete from operator  where operator='" + DropDownList1.SelectedItem.Text + "'";
        ob1.query(upd);
    }
}
