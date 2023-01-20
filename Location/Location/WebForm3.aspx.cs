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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from Locataire", cnx);
            adapter.Fill(ds, "lc");
            dt = ds.Tables["lc"];
            adapter2 = new SqlDataAdapter("select * from Usere", cnx);
            adapter2.Fill(ds,"us");
            dt2 = ds.Tables["us"];

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
            TextBox5.Text = " ";
        }
      public void enreg()
        {
            SqlCommandBuilder d = new SqlCommandBuilder(adapter2);
            adapter2.Update(dt2);
            SqlCommandBuilder c = new SqlCommandBuilder(adapter);
            adapter.Update(dt);  
        }
            
        

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        { string req = ("select Email from Usere");
            DataRow row = dt.NewRow();
            DataRow riw = dt2.NewRow();
            row["Nom_l"] = TextBox1.Text;
            row["Tel_l"] = TextBox2.Text;
            if (req != TextBox3.Text) { 
            row["Email_l"] = TextBox3.Text;
                riw["Email"]= TextBox3.Text;
            if (TextBox4.Text == TextBox5.Text) {
            riw["Psw"] = TextBox4.Text;
            }
            else
            {
                Response.Write("<scripte>alert('mdp incorrecte')</script>");
            }
            dt.Rows.Add(row);
            dt2.Rows.Add(riw);
                enreg();
            Response.Write("<scripte>alert('bien ajouter')</script>");
                Response.Redirect("WebForm2.aspx ?");
            clear();
            }
            else
            {
                Response.Write("<script>alert('Email deja exicter verifier svp')</script>");
            }
            

        }
    }
}