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

    Class1 ob = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {



        lblamount.Text = Request.QueryString["id"].ToString();
        //txtamount.Text = Session["amount"].ToString();
        //txtmob.Text = Session["mob"].ToString();
      lbluser.Text = Session["user"].ToString();
        lbloper.Text = Session["op"].ToString();
        string mob = "select mobno from register where username='" + lbluser.Text + "'";
        SqlDataReader dr = ob.Reader(mob);
        while (dr.Read())
        {
           lblmob.Text = dr["mobno"].ToString();
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //int t, u,z;
        //string y;
        //Session["user"] = txtuser.Text;
        string date = DateTime.Now.ToLongDateString();
        string time = DateTime.Now.ToLongTimeString();
        //transaction.Service pr = new transaction.Service();
        trans.Service pr = new trans.Service();
        Convert.ToString(pr.check(txtaccno.Text));
        int count = pr.balance(Convert.ToDouble(lblamount.Text), txtaccno.Text);
        if (count == 1)
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Transaction Completed Successfully";
            string rechg = "insert into user_rechg_det values('"+lbluser.Text+"','"+lbloper.Text+"','"+lblmob.Text+"','"+lblamount.Text+"','"+date+"','"+time+"')";
            ob.query(rechg);
            string x = "select ta from operator where operator='" + lbloper.Text + "'";
            SqlDataReader dr = ob.Reader(x);
            if (dr.Read())
            {
                int s = Convert.ToInt32(lblamount.Text);
                string n = dr["ta"].ToString();
                int y = Convert.ToInt32(n );
                int l = y - s;
                string m = Convert.ToString(l);
                string upd = "update operator set ta='" + m + "' where operator='" + lbloper.Text + "'";
                ob.query(upd);
            }

            //{

            //    y = dr[2].ToString();


            //    t = Convert.ToString(y);
            //    u = Convert.ToString(txtamount.Text);
            //    z = t - u;
            //}

            //    string upd = "update operator set ta='" + z + "' where operator='" + txtoperator.Text + "'";
            //    ob.query(upd);
            //}
            

            //string x=txtamount.Text ;
            //string upd = "select ta from operator where operator='" + txtoperator.Text + "'";
            //SqlDataReader dr = ob.Reader(upd);
            //while (dr.Read())
            //{
            //    if (x<= dr[3].ToString())
            //    {
            //        string y = dr[3].Tostring() - x;
            //        string upd1 = "update operator set ta='" + y + "'";
            //        ob.query(upd1);
            //    }
            //}
        

           
            
        }
        else
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Transaction Failed";


        }
    }

   
}

