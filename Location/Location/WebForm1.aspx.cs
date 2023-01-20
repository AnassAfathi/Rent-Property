using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Location
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Projet_classeEntities lc = new Projet_classeEntities();
        SqlDataAdapter dt = new SqlDataAdapter();
        DataTable db = new DataTable();
        DataSet ds = new DataSet();
       
        protected void Page_Load(object sender, EventArgs e)
        {
           

            DropDownList1.DataSource = lc.Table1.ToList();
            DropDownList1.DataTextField = "nomcat";
            DropDownList1.DataValueField = "nomcat";
            DropDownList2.DataSource = lc.villes.ToList();
            DropDownList2.DataTextField = "nom_ville";
            DropDownList2.DataValueField = "nom_ville";
            DropDownList1.DataBind();
            DropDownList2.DataBind();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {}

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx?");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx?");
        }
    }
}