using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Penerangan.Emedia2u.Web.Helper;

namespace Penerangan.Emedia2u.Web
{
    public partial class SenaraiPermohonan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string connString = ConnectionString.GetConnectionString();
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("p_TRMS_Permohonan_sel", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            connection.Close();
            permohonanGridview.DataSource = ds.Tables[0];
            permohonanGridview.DataBind();
        }

        protected void permohonanGridview_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "No Borang";
                e.Row.Cells[1].Text = "Nama Pemohon";
                e.Row.Cells[2].Text = "No Kad Pengenalan Pemohon";
                e.Row.Cells[3].Text = "No Telefon bimbit Pemohon";
                e.Row.Cells[4].Text = "Tarikh Permohonan";
                e.Row.Cells[5].Text = "Status Kad Pemohon";
            }
        }
        
    }
}