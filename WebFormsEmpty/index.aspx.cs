using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsEmpty.Models;

namespace WebFormsEmpty
{
    public partial class index : System.Web.UI.Page
    {
        private CountryService countryService;
        public index()
        {
            countryService = new CountryService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewRefresh();
        }
        public void GridViewRefresh()
        {
            GridView1.DataSource = Repos.Repo;
            GridView1.DataBind();
        }

        protected void AddCountryBtn_Click(object sender, EventArgs e)
        {
            countryService.Add(new Country() { Id = 6, Name = "Korea", Capital = "Seol" });
            GridViewRefresh();
        }
    }
}