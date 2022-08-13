using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_Entity_Framework_DB
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBLILETISIM.Find(x);
            TxtADSoyad.Text = mesaj.ADSOYAD;
            TxtKonu.Text = mesaj.KONU;
            TxtMail.Text = mesaj.MAİL;
            TxtMesaj.Text = mesaj.MESAJ;
        }
    }
}