using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lMessage.Visible = false;
           // Session["connecte"] = "sd";
            IEnumerator<Conversion> listeM = DbProvider.findAll().GetEnumerator();
            Conversion conversion;
            TableCell cellule;
            Button addLien;
            while (listeM.MoveNext())
            {
                if (Session["connecte"] != null) //si pas connecter envoie a login
                {
                    conversion = listeM.Current;
                    TableRow ligne = new TableRow();
                    cellule = new TableCell();
                    cellule.Text = conversion.nom;
                    ligne.Cells.Add(cellule);
                    cellule = new TableCell();
                    cellule.Text = conversion.valeur.ToString();
                    ligne.Cells.Add(cellule);
                    cellule = new TableCell();
                    addLien = new Button();
                    addLien.Text = "Convert";
                    addLien.CommandArgument = conversion.valeur.ToString();
                    addLien.Click += new EventHandler(convert_Click);
                    cellule.Controls.Add(addLien);
                    ligne.Cells.Add(cellule);
                    Table1.Rows.Add(ligne);
                }
                else Response.Redirect("Login.aspx"); 
            }

        }
        void convert_Click(object sender, EventArgs e)
        {
            Conversion conversion;
            String typeMonnaie = ((Button)sender).CommandArgument;
            conversion = new Conversion(float.Parse(typeMonnaie));
            lMessage.Visible = true;
            TableCell1.Visible = false;
             float numberToConvert ;    //text = chiffre a convertir
             if (text.Text == "")   //message d'erreur si text est vide 
             {
                 lMessage.Text = "Entrez une valeur supérieur a 0 dans la zone de texte ";
             }
             else
             {
                 numberToConvert = float.Parse(text.Text);
                 float convertedNumber = conversion.converter(numberToConvert);
                 lMessage.Text = convertedNumber.ToString();
             }
            //Response.Redirect("~/lister.aspx");//Pour éviter le double-submit.
        }
    }
}