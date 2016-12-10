using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["connecte"] != null)
            {

                lName.Text = "Bienvenue : " + Session["connecte"].ToString();
                lName.Visible = true;
                bDeconecter.Visible = true;
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            
        }
        protected void bDeconnecter_Click(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Session.Abandon();//destroy une session
            lName.Visible = false;
            bDeconecter.Visible = false;
            Response.Redirect("~/lister.aspx");
        }
       
    }
}