using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
public partial class Destinatario : System.Web.UI.Page
{
    dbHelper help = new dbHelper("FioriEPiante.accdb");
    OleDbDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {
        string utente = Session["Utente"].ToString();
        help.connetti();
        help.assegnaComando("SELECT CognomeNome FROM Destinatario WHERE Cod_Utente = '"+utente+"'");
        rs = help.estraiDati();
        DropDownList1.Items.Add("");
        while(rs.Read())
        {
            DropDownList1.Items.Add(rs["CognomeNome"].ToString());
        }
        help.disconnetti();
    }

    protected void TxtPass_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string prodotto = Session["Prodotto"].ToString();
            string qta = Session["qta"].ToString();

            int nuovaQta;
            help.connetti();
            help.assegnaComando("SELECT Quantità FROM Prodotti WHERE ID_Prodotto='" + prodotto + "'");
            rs = help.estraiDati();
            rs.Read();
            nuovaQta = int.Parse(rs["Quantità"].ToString()) - int.Parse(qta);
            help.disconnetti();

            help.connetti();
            help.assegnaComando("UPDATE Prodotti SET Quantità = '" + nuovaQta + "' WHERE ID_Prodotto='" + prodotto + "'");
            help.eseguicomando();
            help.disconnetti();

            help.connetti();
            help.assegnaComando("SELECT Prezzo FROM Prodotti WHERE ID_Prodotto='" + prodotto + "'");
            rs = help.estraiDati();
            rs.Read();
            int spesatot = int.Parse(rs["Prezzo"].ToString()) * int.Parse(qta);
            help.disconnetti();

            string oggi = DateTime.Today.ToString();
            help.connetti();
            help.assegnaComando("SELECT Nome FROM Prodotti WHERE ID_Prodotto='" + prodotto + "'");
            rs = help.estraiDati();
            rs.Read();
            string nome = rs["Nome"].ToString();
            string descr = "Acquisto di " + qta + " " + nome;
            help.disconnetti();

            help.connetti();
            help.assegnaComando("INSERT INTO Acquisti(Spesatot,DataAcquisto,Descr,Cod_Utente) VALUES(" + spesatot + ",#" + oggi + "#,'" + descr + "','" + Session["Utente"].ToString() + "')");
            help.eseguicomando();
            help.disconnetti();
            if(DropDownList1.Text=="")
            {
                string nomecognome = TxtEmail.Text;
                string indirizzo = TxtIndirizzo.Text;
                string città = txtCittà.Text;
                string messaggio = txtMsg.Text;
                string utente = Session["Utente"].ToString();
                help.connetti();
                help.assegnaComando("INSERT INTO Destinatario (CognomeNome,Indirizzo,Città,Messaggio,Cod_Utente) VALUES ('" + nomecognome + "','" + indirizzo + "','" + città + "','" + messaggio + "','" + utente + "')");
                help.eseguicomando();
                help.disconnetti();
                Session["Grazie"] = "Grazie";
                Response.Redirect("Grazie.aspx");
            }
            else
            {
                Session["Grazie"] = "Grazie";
                Response.Redirect("Grazie.aspx");
            }
        }
        catch
        {
            Response.Write("Qualcosa non va");
        }
    }
}