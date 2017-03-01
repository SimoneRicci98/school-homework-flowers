using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
public partial class Acquista : System.Web.UI.Page
{
    dbHelper help = new dbHelper("FioriEPiante.accdb");
    OleDbDataReader rs;
    int qtaprod;
    protected void Page_Load(object sender, EventArgs e)
    {
        string prodotto = Session["Prodotto"].ToString();
        help.connetti();
        help.assegnaComando("SELECT * FROM Prodotti WHERE ID_Prodotto ='" + prodotto + "'");
        rs = help.estraiDati();
        rs.Read();
        qtaprod = int.Parse(rs["Quantità"].ToString());
        Image3.ImageUrl = rs["Immagine"].ToString();
        lblPrd.Text = rs["Nome"].ToString();
        lblPrezzo.Text = "Prezzo: "+ rs["Prezzo"].ToString() + "€";
        help.disconnetti();

        if (!IsPostBack)
        {
            ViewState["cont"] = 0;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if((int)ViewState["cont"]!=qtaprod)
        {
            ViewState["cont"] = (int)ViewState["cont"] + 1;
            TextBox1.Text = ViewState["cont"].ToString();
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if((int)ViewState["cont"] != 0)
        {
            ViewState["cont"] = (int)ViewState["cont"] - 1;
            TextBox1.Text = ViewState["cont"].ToString();
        }
    }

    protected void btnAcquista_Click(object sender, EventArgs e)
    {
        Session["qta"] = TextBox1.Text;
        
        if (Session["Utente"]==null)
        {
            lblbErr.Text = "Effettua prima il login!";
        }
        else
        {
            Response.Redirect("Destinatario.aspx");
        }
    }

    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {

    }
}