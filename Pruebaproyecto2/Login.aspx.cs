using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pruebaproyecto2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsername_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string correo = txtUsername.Text;

            string contraseña = txtPassword.Text;

            // Obtener la cadena de conexión desde el archivo de configuración

            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                connection.Open();

                // Verificar las credenciales en la base de datos

                string query = "SELECT COUNT(*) FROM Ingresar WHERE Correo = @Correo AND Contraseña = @Contraseña";

                using (SqlCommand command = new SqlCommand(query, connection))

                {

                    command.Parameters.AddWithValue("@Correo", correo);

                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)

                    {

                        // Credenciales válidas, redirige a la página de inicio.

                        Response.Redirect("Equipos.aspx");
                        
                    }

                    else

                    {

                        // Credenciales inválidas, muestra un mensaje de error.

                        Response.Write("Credenciales inválidas. Por favor, inténtalo de nuevo.");

                    }

                }

            }
        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string correo = txtUsername.Text;
            string contraseña = txtPassword.Text;

            // Obtener la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["examenNprogramacioN"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insertar nuevo usuario en la tabla
                string insertQuery = "INSERT INTO Ingresar (Correo, Contraseña) VALUES (@Correo, @Contraseña)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Response.Write("Usuario creado correctamente.");
                    }
                    else
                    {
                        Response.Write("Error al crear el usuario. Por favor, inténtalo de nuevo.");
                    }
                }
            }
        }

        protected void txtPassword_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}