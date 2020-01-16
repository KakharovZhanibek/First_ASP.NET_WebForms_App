using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsEmpty.Models;

namespace WebFormsEmpty
{
    public partial class Second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Country country1 = (Country)Session["s1"];
            Country country2 = Session["s1"]as Country;
            
        }
    }
}