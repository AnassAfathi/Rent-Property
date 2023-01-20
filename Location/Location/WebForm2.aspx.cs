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
    public partial class WebForm2 : System.Web.UI.Page
      
    {
        //locamaisonEntities1 lc = new locamaisonEntities1();
        Projet_classeEntities lc = new Projet_classeEntities();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            var req = (from x in lc.Useres where x.Email.ToString()==TextBox1.Text & x.Psw.ToString()==TextBox2.Text select x ).FirstOrDefault();
            
            if (req != null)
            {
                Response.Write("<script>alert('connection avec succes')</script>");
                //Response.Redirect("");
                Response.Redirect("WebForm4.aspx?parm="+TextBox1.Text+"");
                Response.Redirect("WebForm4.aspx?");
            }
            else
            {
                Response.Write("<script>alert('mdp ou login incorrecte')</script>");
               
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx?");
        }
    }
}