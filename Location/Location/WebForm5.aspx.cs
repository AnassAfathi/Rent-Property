using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Location
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select Titre_im,Ville_im,Adresse_im,Descri_im ,Locatairee,Prix,Date_cre  from Imobilier ", cnx);
                SqlDataReader dr = cmd.ExecuteReader();

                table.Append("<table border='solid 400px'>");
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        table.Append("<tr>");
                        table.Append("<td>" + dr[0] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                        table.Append("<td>" + dr[1] + "<br>" + dr[2] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                        table.Append("<td>" + dr[4]+"<br>"+ dr[5] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                        table.Append("<td>" + dr[3] + "&nbsp&nbsp&nbsp&nbsp" +  " </td>");
                        table.Append("<td>" + dr[6] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                dr.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx?");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select Titre_im,Ville_im,Adresse_im,Descri_im ,Locatairee,Prix,Date_cre  from Imobilier where Categ_im ="+DropDownList2.SelectedValue, cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            table.Append("<table border='solid 400px'>");
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    table.Append("<tr>");
                    table.Append("<td>" + dr[0] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[1] + "<br>" + dr[2] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[4] + "<br>" + dr[5] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[3] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[6] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("</tr>");
                }
            }
            table.Append("</table>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            dr.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select Titre_im,Ville_im,Adresse_im,Descri_im ,Locatairee,Prix,Date_cre  from Imobilier where Ville_im ="+DropDownList1.SelectedValue, cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            table.Append("<table border='solid 400px'>");
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    table.Append("<tr>");
                    table.Append("<td>" + dr[0] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[1] + "<br>" + dr[2] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[4] + "<br>" + dr[5] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[3] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[6] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("</tr>");
                }
            }
            table.Append("</table>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            dr.Close();
        }

        protected void Button7_Click1(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-KSEB0IM\SQLEXPRESS;Initial Catalog=Projet_classe;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select Titre_im,Ville_im,Adresse_im,Descri_im ,Locatairee,Prix,Date_cre  from Imobilier ", cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            table.Append("<table border='solid red 1px'>");
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    table.Append("<tr>");
                    table.Append("<td>" + dr[0] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[1] + "<br>" + dr[2] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[4] + "<br>" + dr[5] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[3] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("<td>" + dr[6] + "&nbsp&nbsp&nbsp&nbsp" + " </td>");
                    table.Append("</tr>");
                }
            }
            table.Append("</table>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            dr.Close();
        }
    }
}