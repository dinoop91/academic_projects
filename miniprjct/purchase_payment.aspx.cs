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
        string model = Request.QueryString["model"].ToString();
        lblmodel.Text = model;
        //string a = txtmodel.Text.ToString();

        string str = "select price from mobdet where model='" + lblmodel.Text+ "'";
        SqlDataReader dr = ob1.Reader(str);
        while (dr.Read())
        {
            lblprice.Text = dr["price"].ToString();
        }
      
        lbluser.Text  = Session["user"].ToString();
   
        lblcomp.Text = Session["comp"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
  
        string date = DateTime.Now.ToLongDateString();
        string time = DateTime.Now.ToLongTimeString();

        //Session["user"] = txtuser.Text.ToString();
        //Server.Transfer("payment.aspx");
        //transaction.Service pr = new transaction.Service();
        trans.Service pr = new trans.Service();
        Convert.ToString (pr.check(txtaccno.Text));
        int count = pr.balance(Convert.ToDouble(lblprice.Text), txtaccno.Text);
        if (count == 1)
        {
            lbmsg.Visible = true;
            lbmsg.Text = "Transaction Completed Successfully";
            string purchase = "insert into user_purchase_det values('" + lbluser.Text + "','" + lblcomp.Text + "','" + lblmodel.Text + "','" + lblprice.Text + "','" + date + "','" + time + "')";
            ob1.query(purchase);

            string i = "select count from mobdet where model='" + lblmodel.Text + "'";
            SqlDataReader dr = ob1.Reader(i);
            if (dr.Read())
            {
                string x = dr["count"].ToString();
                int y = Convert.ToInt32(x);
                if (y >= 1)
                {
                    int j = y - 1;
                    string m = Convert.ToString(j);
                    string upd = "update mobdet set count='" + m + "' where model='" + lblmodel.Text + "'";
                    ob1.query(upd);

                    if (y == 1)
                    {


                        string del = "delete from mobdet where model='" + lblmodel.Text + "'";
                        ob1.query(del);
                    }
                }


            }


        }

        else
        {
            lbmsg.Visible = true;
            lbmsg.Text = "Transaction Failed";

        }
 
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
        Session["user"] = null;
    }
    
}
