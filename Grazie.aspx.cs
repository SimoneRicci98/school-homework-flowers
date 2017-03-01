using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Grazie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(2000);

        HiddenField1.Value = Session["grazie"].ToString();
    }

    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}