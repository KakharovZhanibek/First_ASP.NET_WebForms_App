using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsEmpty.Implementations;
using WebFormsEmpty.Interfaces;
using WebFormsEmpty.Models;


namespace WebFormsEmpty
{
    public partial class index : System.Web.UI.Page
    {
        //private CountryService countryService;
        private readonly IMultiService<Country> countryService;
        public index()
        {
            countryService = new CountryServiceEF();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            countryService.Add(new Country { Id=9,Name="Italy",Capital="Rome"});
            GridViewRefresh();
            //Session["DateTime_Now"] = DateTime.Now;
            //Session["Date_Now"] = DateTime.Now.Date;

            //Country country = new Country() {Id=9,Name="England",Capital="London"};
            //Session["s1"] = country;


            //countryService.Add(new Country() { Name="China",Capital="Pekin" });
            //countryService.Delete(4);
            

        }
        public void GridViewRefresh()
        {
            GridView1.DataSource = countryService.GetAll();
            GridView1.DataBind();
        }

        protected void AddCountryBtn_Click(object sender, EventArgs e)
        {
            TextBox tbxId = new TextBox();
            TextBox tbxName = new TextBox();
            TextBox tbxCapital = new TextBox();
            Button addBtn = new Button();
            tbxId.Style["width"] = "80px";
            tbxName.Style["width"] = "80px";
            tbxCapital.Style["width"] = "80px";
            tbxId.ID = "tbxId";
            tbxName.ID = "tbxName";
            tbxCapital.ID = "tbxCapital";

            addBtn.Text = "Add";
            addBtn.Click += AddBtn_Click;

            form1.Controls.Add(tbxId);
            form1.Controls.Add(tbxName);
            form1.Controls.Add(tbxCapital);
            form1.Controls.Add(addBtn);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void DeleteCountry_Click(object sender, EventArgs e)
        {
            GridView1.DeleteRow(Convert.ToInt32(GridView1.SelectedRow.ID));
        }

        protected void EditCountry_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}