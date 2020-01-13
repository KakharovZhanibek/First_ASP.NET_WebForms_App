using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsEmpty
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TB_3.Text = "Load";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            TB_3.Text = "Init";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TB_3.Text = (Convert.ToInt32(TB_1.Text) + Convert.ToInt32(TB_2.Text)).ToString();
        }
    }
}