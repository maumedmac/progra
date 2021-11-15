using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias
//Instanciamos para que nos reconozca las clases
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using CAPA_ENTIDAD;

   public class Conexion
    {
       public SqlConnection conecta()
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
           return con;
       }
        //AQUI CONECTO EL SERVIDOR
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-9JTFR83\\ESTHER;Initial Catalog=empresaProducto;Integrated Security=True");
        //public SqlConnection AbrirConexion()
        //{
        //    if (conexion.State == ConnectionState.Closed)
        //        conexion.Open();
        //    return conexion;
        //}
        //public SqlConnection CerrarConexion()
        //{
        //    if (conexion.State == ConnectionState.Open)
        //        conexion.Close() ;
        //    return conexion;
        //}
    }

