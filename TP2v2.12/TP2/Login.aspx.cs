using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lMessage.Visible = false;
            //Response.Write("connected");
        }
        protected void bConnecterr_Click(object sender, EventArgs e)
        {
            Connexion cnx = new Connexion();
            cnx.setUserName(uName.Text); 
            cnx.setPassword(psw.Text);
            if (DbProvider.readLogin(cnx))
            {
                Session["connecte"] = cnx.getUsername();  //ouvrir une session
                Response.Redirect("lister.aspx");//si connecter envoie ;a la page principale
                //Response.Write("connected2");
            }
            else
            {
                 lMessage.Text = "L'autentification à échoué / Please enter valid Username and Password";
                lMessage.Visible = true;
            }
        }
    }
}