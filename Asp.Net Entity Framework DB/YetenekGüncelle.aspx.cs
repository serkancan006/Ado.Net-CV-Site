using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_Entity_Framework_DB
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var ytnk = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = ytnk.YETENEK;


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var ytnk = db.TBLYETENEKLER.Find(x);
            TextBox1.Text = ytnk.YETENEK;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}