using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Location
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string file = string.Empty;
        Projet_classeEntities lc = new Projet_classeEntities();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = lc.Table1.ToList();
            //DropDownList1.DataSource = lc.Categories.ToList();
            DropDownList1.DataTextField = "nomcat";
            DropDownList1.DataValueField = "nomcat";
            //ID_cat
            DropDownList2.DataSource = lc.villes.ToList();
            DropDownList2.DataTextField = "nom_ville";
            DropDownList2.DataValueField = "nom_ville";

            DropDownList1.DataBind();
            DropDownList2.DataBind();
            TextBox5.Text=Request.QueryString["parm"];
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            photoo ph = new photoo();
            Imobilier im = new Imobilier();
            Categorie cat = new Categorie();
            Locataire loc = new Locataire();
            cat.Nom_cat = DropDownList1.SelectedValue;
            im.Categ_im =cat.ID_cat;
            im.Ville_im = DropDownList2.SelectedValue;
            im.Adresse_im = TextBox1.Text;
            im.Titre_im = TextBox4.Text;
            im.Descri_im = TextBox2.Text;
            im.Locatairee = Request.QueryString["parm"];
            im.Date_cre = DateTime.Now;
            im.Prix = int.Parse(TextBox3.Text);
            //ph.Titre_im = TextBox4.Text;
            //ph.Photos = FileUpload1.ToString();
            //**********************ajout de photos
            if (FileUpload2.HasFile)
            {
                FileUpload2.SaveAs(Server.MapPath("~/image/" + FileUpload2.FileName));
                file = "~/image/" + FileUpload2.FileName;
            }
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into [Photoo] values(@test,@im)";
            cmd.Parameters.AddWithValue("@test", "test");
            cmd.Parameters.AddWithValue("@im", file);
            cmd.Connection = cnx;
            //int c = cmd.ExecuteNonQuery();
            //if (c > 0)
            //{
            //    Response.Write("image inserted");
            //}

            //cnx.Close();_
            //***************termine d'ajout de photos
            //lc.photoos.Add(ph);
            lc.Imobiliers.Add(im);
            lc.Categories.Add(cat);
            lc.SaveChanges();
            Response.Write("<script>alert('annonce ajouter')</script>");
            Response.Redirect("WebForm5.aspx?");
            
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                FileUpload2.SaveAs(Server.MapPath("~/Photo/" + FileUpload2.FileName));
                file = "~/Photo/" + FileUpload2.FileName;
            }
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Photo values(@test,@im)";
            cmd.Parameters.AddWithValue("@test", "test");
            cmd.Parameters.AddWithValue("@im", file);
            cmd.Connection = cnx;
            int c = cmd.ExecuteNonQuery();
           

            cnx.Close();
        }
        public void ajouter()
        {
            if (FileUpload2.HasFile)
            {
                FileUpload2.SaveAs(Server.MapPath("~/Photoo/" + FileUpload2.FileName));
                file = "~/Photo/" + FileUpload2.FileName;
            }
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Photoo values(@test,@im)";
            cmd.Parameters.AddWithValue("@test", "test");
            cmd.Parameters.AddWithValue("@im", file);
            cmd.Connection = cnx;
            int c = cmd.ExecuteNonQuery();
            

            cnx.Close();
        } photoo ph = new photoo();
        public void anchof()
        {
            if(FileUpload2.HasFile)
            {
                
            }
        }
    }
}