﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_Entity_Framework_DB
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = db.TBLYETENEKLER.Find(x);
            db.TBLYETENEKLER.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}