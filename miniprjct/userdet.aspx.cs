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
    Class1 ob3 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        string grid1 = "select * from user_rechg_det";
        SqlDataReader dr = ob3.Reader(grid1);
        GridView1.DataSource = dr;
        GridView1.DataBind();
        string grid2 = "select * from user_purchase_det";
        SqlDataReader dr1 = ob3.Reader(grid2);
        GridView2.DataSource = dr1;
        GridView2.DataBind();

    }
   
   
}
