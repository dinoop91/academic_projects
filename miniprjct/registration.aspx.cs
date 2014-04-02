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

public partial class Default3 : System.Web.UI.Page
{
    Class1 obj2 = new Class1();
    public int val()
    {
        int v = 0;
        if (txtname.Text == "")
        {
            lblname.Visible = true;
            v = 1;
        }
        if (txtuser.Text == "")
        {
            lbluser.Visible = true;
            v = 1;
        }
        if (txtpswd.Text == "")
        {
            lblpswd.Visible = true;
            v = 1;
        }
        if (txtcon.Text == "")
        {
            lblconfirm.Visible = true;
            v = 1;
        }
        if (RadioButtonList1.Text == "")
        {
            lblgend.Visible = true;
            v = 1;
        }
        if (drpdate.Text == "date")
        {
            lbldob.Visible = true;
            v = 1;
        }
        if (drpmonth.Text == "month")
        {
            lbldob.Visible = true;
            v = 1;
        }
        if (drpyear.Text == "year")
        {
            lbldob.Visible = true;
            v = 1;
        }
        if (txthname.Text == "")
        {
            lblhname.Visible = true;
            v = 1;
        }
        if (txtplace.Text == "")
        {
            lblplace.Visible = true;
            v = 1;
        }
        if (txtpin.Text == "")
        {
            lblpin.Visible = true;
            v = 1;
        }
        if (txtmob.Text == "")
        {
            lblmob.Visible = true;
            v = 1;
        }
        if (txtpswd.Text != txtcon.Text)
        {
            lblconfirm.Visible = true;
            lblconfirm.Text = "Please reenter your password";
            v = 1;
        }

        return v;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //fun();
        lblname.Visible = false;
        lbluser.Visible = false;
        lblpswd.Visible = false;
        lblconfirm.Visible = false;
        lblgend.Visible = false;
        lbldob.Visible = false;
        lblhname.Visible = false;
        lblplace.Visible = false;
        lblpin.Visible = false;
        lblmob.Visible = false;
        availability.Visible = false;
        for (int i = 1; i <= 31; i++)
        {
            drpdate.Items.Add(i.ToString());
        }
        drpdate.Items.Insert(0, "date");
        for (int j = 1; j <= 12; j++)
        {
            drpmonth.Items.Add(j.ToString());
        }
        drpmonth.Items.Insert(0, "month");
        for (int k = 1880; k <=2000; k++)
        {
            drpyear.Items.Add(k.ToString());
        }
        drpyear.Items.Insert(0, "year");

    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
       int a=val();
        if(a!=1)
        {
        string avail = "select username from login1 where username='"+txtuser.Text+"'";
        SqlDataReader dr =obj2.Reader(avail);
        if (dr.Read())
        {
            availability.Visible = true;
            availability.Text = "not available";

        }
        else
        {

            string dob = drpdate.SelectedItem.Value + "|" + drpmonth.SelectedItem.Value + "|" + drpyear.SelectedItem.Value;
            string i = "insert into register values('" + txtname.Text + "','" + txtuser.Text + "','" + RadioButtonList1.Text + "','" + dob + "','" + txthname.Text + "','" + txtplace.Text + "','" + txtpin.Text + "','" + txtmob.Text + "')";

            string l = "insert into login1 values('" + txtuser.Text + "','" + txtpswd.Text + "','user')";
            obj2.query(i);
            obj2.query(l);
        }
    }

}

    protected void rdbtnmale_CheckedChanged(object sender, EventArgs e)
    {

    }
}
