using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria para trabajar con bases de datos
using System.Data.SqlClient;
using System.Drawing.Text; //Esta  libreria me permite traajar con SQL Server

namespace primerProyecto
{
    internal class Conexion1
    {
    
            //Definir los miembros de la clase, atributos y metodos.
            SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD.
            SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
            SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
            DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en memoria.

            public Conexion1()
            { //Constructor. inicializador de los atributos
                String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
                objConexion.ConnectionString = cadenaConexion;
                objConexion.Open(); //Abrir la conexion a la BD
            }
            public DataSet obtenerDatos()
            {
                objDs.Clear(); //Limpiar el DataSet
                objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

                objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

                objComando.CommandText = "SELECT * FROM alumnos";
                objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM Docentes";
            objAdaptador.Fill(objDs, "Docentes");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM Materias";
            objAdaptador.Fill(objDs, "Materias");//Tomando los datos de la BD y llenando el DataSet
            return objDs;
            }


            public string administrarDatosAlumnos(String[] datos, String accion)
            {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
                }
                return ejecutarSQL(sql, datos);
            }
        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idAlumno", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

            public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Docentes(codigo,nombre,direccion,telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
            }
            return ejecutarSQL1(sql, datos);
        }
        private String ejecutarSQL1(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idDocente", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        }
    }


