using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReflectionDemo
{
    public partial class VrijwilligerWijzigen : System.Web.UI.Page
    {
        private ReflectionDemo.CC.VrijwilligerWijzigen cc;

        protected void Page_Load(object sender, EventArgs e)
        {
            cc = new ReflectionDemo.CC.VrijwilligerWijzigen();
            if (!IsPostBack)
            {
                Refresh();
            }
        }

        protected void btOpslaan_Click(object sender, EventArgs e)
        {
            Dictionary<String, object> vrijwilliger = new Dictionary<string, object>();
            vrijwilliger.Add("Voornaam", tbVoornaam.Text);
            vrijwilliger.Add("Achternaam", tbAchternaam.Text);
            vrijwilliger.Add("Schoenmaat", tbSchoenmaat.Text);
            vrijwilliger.Add("Geboortedatum", tbGeboortedatum.Text);
            cc.DoeIetsAnders(vrijwilliger);
            Refresh();
        }

        void Refresh()
        {
            Dictionary<String, object> vrijwilliger = cc.DoeIets();
            tbVoornaam.Text = vrijwilliger["Voornaam"].ToString();
            tbAchternaam.Text = vrijwilliger["Achternaam"].ToString();
            tbSchoenmaat.Text = vrijwilliger["Schoenmaat"].ToString();
            tbGeboortedatum.Text = vrijwilliger["Geboortedatum"].ToString();
        }
    }
}