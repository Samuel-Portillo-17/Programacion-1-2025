using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria para trabajar con bases de datos
using System.Data.SqlClient; //Esta  libreria me permite traajar con SQL Server

namespace primerProyecto
{
    internal class Conexion {
        //Definir los miembros de la clase, atributos y metodos
        SqlConnection objConexion = new SqlConnection(); //conectarme a la BD.
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, actualizacion, Eiminacion, insertar
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en la memoria

        public Conexion() { //Constructor. Inicializador de los atributos
            String cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()  {
         objDs.Clear(); //Limpiar el dataset    
         objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos
         
            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM alumno"; 
            objAdaptador.Fill(objDs, "alumno"); //Tomando los datos de la BD y llenando el dataset

            return objDs; 
        }

    }
}
