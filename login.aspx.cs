using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class login : System.Web.UI.Page
{
    dbHelper help = new dbHelper("FioriEPiante.accdb");
    OleDbDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Utente"] == null)
        {
            lblLogin.Text = "Login";
            Label1.Visible = true;
            Label2.Visible = true;
            TxtEmail.Visible = true;
            TxtPass.Visible = true;
            Button1.Visible = true;
            Button2.Visible = false;
            Button3.Visible = false;
            Label3.Visible = true;
            Label4.Visible = true;
            txtEmailReg.Visible = true;
            txtPswReg.Visible = true;
            Button4.Visible = true;
            lblReg.Visible = true;
        }
        else
        {
            lblLogin.Text = "Area Personale";
            Label1.Visible = false;
            Label2.Visible = false;
            TxtEmail.Visible = false;
            TxtPass.Visible = false;
            Button1.Visible = false;
            Button2.Visible = true;
            Button3.Visible = true;
            Label3.Visible = false;
            Label4.Visible = false;
            txtEmailReg.Visible = false;
            txtPswReg.Visible = false;
            Button4.Visible = false;
            lblReg.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string email;
        string password;
        email = TxtEmail.Text;
        password = TxtPass.Text;
        try
        {
            help.connetti();
        help.assegnaComando("SELECT ID_Utente FROM Utenti WHERE Email='"+email+"' AND Password='"+password+"'");
        rs = help.estraiDati();
        rs.Read();
            Session["Utente"] = rs["ID_Utente"].ToString();
            help.disconnetti();
            Response.Redirect("Default.aspx");

        }
        catch
        {
            help.disconnetti();
            lblErr.Text = "Nome utente o password errati!";
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["Utente"] = null;
        Response.Redirect("Default.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            int app = 0;
            string email = txtEmailReg.Text;
            string psw = txtPswReg.Text;
            help.connetti();
            help.assegnaComando("SELECT MAX (ID_Utente) AS massimo FROM Utenti");
            rs = help.estraiDati();
            rs.Read();
            app = int.Parse(rs["massimo"].ToString()) + 1;
            help.disconnetti();

            help.connetti();
            help.assegnaComando("INSERT INTO Utenti VALUES('" + app + "','"+email+"','"+psw+"')");
            help.eseguicomando();
            help.disconnetti();
            Response.Redirect("Default.aspx");
            Session["Utente"] = app.ToString();
        }
        catch
        {
            lblErr0.Text = "Compila tutti i campi";
        }
    }

}