using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("TextBox4")).Text;

            SqlDataSource1.InsertParameters["gender"].DefaultValue =
                ((DropDownList)GridView1.FooterRow.FindControl("DropDownList1")).SelectedValue;

            SqlDataSource1.InsertParameters["class"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("TextBox5")).Text;

            int statusCode = SqlDataSource1.Insert();
            if (statusCode > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion successful')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Insertion failed')</script>");
            }
        }
    }
}