using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
public partial class _Default : System.Web.UI.Page
{
    dbHelper help = new dbHelper("FioriEPiante.accdb");
    OleDbDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["Utente"]==null)
        {
            lblLogin.Text = "Login";
        }
        else
        {
            lblLogin.Text = "Area Personale";
        }

        help.connetti();
        help.assegnaComando("SELECT * FROM Prodotti");
        rs = help.estraiDati();
        //+++++++++++++++++PRODOTTO1++++++++++++++++++++++++++
        rs.Read();
        imgbtnProd1.ImageUrl = rs["Immagine"].ToString();
        lblProd1.Text = rs["Nome"].ToString();
        lblMag1.Text = lblMag1.Text + rs["Quantità"].ToString()+"pz.";
        lblPrezzo1.Text = lblPrezzo1.Text + rs["Prezzo"].ToString()+"€";

        //+++++++++++++++++PRODOTTO2++++++++++++++++++++++++++
        rs.Read();
        lblProd2.Text = rs["Nome"].ToString();
        imgbtnProd2.ImageUrl = rs["Immagine"].ToString();
        lblMag2.Text = lblMag2.Text + rs["Quantità"].ToString() + "pz.";
        lblPrezzo2.Text = lblPrezzo2.Text + rs["Prezzo"].ToString() + "€";

        //+++++++++++++++++PRODOTTO3++++++++++++++++++++++++++
        rs.Read();
        lblProd3.Text = rs["Nome"].ToString();
        imgbtnProd3.ImageUrl = rs["Immagine"].ToString();
        lblMag3.Text = lblMag3.Text + rs["Quantità"].ToString() + "pz.";
        lblPrezzo3.Text = lblPrezzo3.Text + rs["Prezzo"].ToString() + "€";

        //+++++++++++++++++PRODOTTO4++++++++++++++++++++++++++
        rs.Read();
        lblProd4.Text = rs["Nome"].ToString();
        imgbtnProd4.ImageUrl = rs["Immagine"].ToString();
        lblMag4.Text = lblMag4.Text + rs["Quantità"].ToString() + "pz.";
        lblPrezzo4.Text = lblPrezzo4.Text + rs["Prezzo"].ToString() + "€";
        help.disconnetti();

    }

    protected void imgbtnProd1_Click(object sender, ImageClickEventArgs e)
    {
        Session["Prodotto"] = "1";
        Response.Redirect("Acquista.aspx");
    }



    protected void imgbtnProd2_Click1(object sender, ImageClickEventArgs e)
    {
        Session["Prodotto"] = "2";
        Response.Redirect("Acquista.aspx");
    }

    protected void imgbtnProd3_Click1(object sender, ImageClickEventArgs e)
    {
        Session["Prodotto"] = "3";
        Response.Redirect("Acquista.aspx");
    }

    protected void imgbtnProd4_Click(object sender, ImageClickEventArgs e)
    {
        Session["Prodotto"] = "4";
        Response.Redirect("Acquista.aspx");
    }
}