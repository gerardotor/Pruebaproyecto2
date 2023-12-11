﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pruebaproyecto2
{
    public partial class Asignaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGridView();

            }
        }

        protected void txtEquipoID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtTecnicoID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFechaAsignacion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregarAsignacion_Click(object sender, EventArgs e)
        {
            try
            {
                int equipoID = Convert.ToInt32(txtEquipoID.Text);
                int tecnicoID = Convert.ToInt32(txtTecnicoID.Text);
                DateTime fechaAsignacion = Convert.ToDateTime(txtFechaAsignacion.Text);

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString))
                {
                    con.Open();
                    string query = "INSERT INTO AAsignacioneSS (EquipoID, TecnicolD, FechaAsignacic) VALUES (@EquipoID, @TecnicoID, @FechaAsignacion)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                        cmd.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                        cmd.Parameters.AddWithValue("@FechaAsignacion", fechaAsignacion);

                        cmd.ExecuteNonQuery();
                    }
                }

                LlenarGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la asignación: " + ex.Message);
            }
        }

        protected void gridAsignaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarAsignaciones()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString))
            {
                con.Open();
                string query = "SELECT AsignacionID, EquipoID, TecnicolD, FechaAsignacic FROM AAsignacioneSS";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gridAsignaciones.DataSource = dt;
                        gridAsignaciones.DataBind();
                    }
                }
            }
        }
        private void LlenarGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AAsignacioneSS";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Llenar el GridView con los resultados
                        gridAsignaciones.DataSource = dt;
                        gridAsignaciones.DataBind();
                    }
                }
            }
        }
    }
}
