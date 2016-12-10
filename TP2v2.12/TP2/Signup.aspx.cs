using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace TP2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lMessage.Visible = false;
            
        }
        protected void bAjouter_Click(object sender, EventArgs e) 
        {
            String messageErreur ;
            Connexion cnx = new Connexion();
            if (cnx.nameValidation(uName.Text).Equals("true")) 
                if (cnx.psswValidation(psw.Text,psw2.Text).Equals("true"))
                {
                    cnx.setUserName(uName.Text);
            
                 cnx.setPassword(psw.Text);
                  if (DbProvider.create(cnx))
                     {
                         lMessage.Text = "Enregistement de  " + cnx.getUsername() + " reussi";
                         lMessage.ForeColor = System.Drawing.Color.Green;
                         lMessage.Visible = true;
                     }
                     else
                     {
                       lMessage.Text = "L'ajout a échoué";
                       lMessage.Visible = true;
                       lMessage.ForeColor = System.Drawing.Color.Red;
                     }
                  }
                    else
                    {
                        //messageErreur = cnx.nameValidation(uName.Text);
                        messageErreur = cnx.psswValidation(psw.Text,psw2.Text);
                        lMessage.Text = "L'ajout a échoué" + messageErreur;
                        lMessage.ForeColor = System.Drawing.Color.Red;
                        lMessage.Visible = true;
                    }  
            else 
             {
                 messageErreur = cnx.nameValidation(uName.Text);
                 //messageErreur = cnx.psswValidation(psw.Text);
                 lMessage.Text = "L'ajout a échoué"+ messageErreur;
                 lMessage.ForeColor = System.Drawing.Color.Red;
                 lMessage.Visible = true;
             }
 
        }
    }
}