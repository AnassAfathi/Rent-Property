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
        SqlConnection cnx = new SqlConnection(@"Data Source=desktop-lposi29\sqlexpress;Initial Catalog=locamaison;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from Locatairre", cnx);
            adapter.Fill(ds, "lc");
            dt = ds.Tables["lc"];
            adapter2 = new SqlDataAdapter("select * from Users", cnx);
            adapter2.Fill(ds,"us");

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
      
            
        

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        { string req = ("select Email from Users");
            DataRow row = dt.NewRow();
            DataRow riw = dt2.NewRow();
            row["Nom_l"] = TextBox1.Text;
            row["Tel_l"] = TextBox2.Text;
            if (req != TextBox3.Text) { 
            row["Email_l"] = TextBox3.Text;
            if (TextBox4.Text == TextBox5.Text) {
            riw["Password"] = TextBox4.Text;
            }
            else
            {
                Response.Write("<scripte>alert('mdp incorrecte')</script>");
            }
            dt.Rows.Add(row);
            dt2.Rows.Add(riw);
            Response.Write("<scripte>alert('bien ajouter')</script>");
            clear();
            }
            else
            {
                Response.Write("<script>alert('Email deja exicter verifier svp')</script>");
            }
            

        }
    }
}