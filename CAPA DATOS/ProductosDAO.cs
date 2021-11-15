using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
   public class ProductosDAO
    {
        SqlConnection con;
               
       Conexion objCon = new Conexion();
       // mostrar PRODUCTO
       public DataTable MOSTRARproducto()
       {
           con = objCon.conecta();
           SqlDataAdapter da = new SqlDataAdapter("select * from Productos", con);
           DataTable dt = new DataTable();
           da.Fill(dt);
           return dt;
       }

       // INSERTAR UNA NUEVA CATEGORIA
       public void AGREGARproducto(Producto P)
       {
           con = objCon.conecta();
           con.Open();
           SqlDataAdapter da = new SqlDataAdapter();
           da.InsertCommand = new SqlCommand("insert into Productos values(@idP, @nom,@fotoP, @precioC, @precioV)", con);
           da.InsertCommand.Parameters.Add("@idP", SqlDbType.VarChar).Value = P.idProducto;
           da.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = P.nombre;
           da.InsertCommand.Parameters.Add("@fotoP", SqlDbType.Binary).Value = P.foto;
           da.InsertCommand.Parameters.Add("@precioC", SqlDbType.Float).Value = P.precioC;
           da.InsertCommand.Parameters.Add("@precioV", SqlDbType.Float).Value = P.precioV;
           try
           {
               da.InsertCommand.ExecuteNonQuery();

           }
           catch (Exception x)
           {

           }
           finally
           {
               con.Close();
           }

       }
       // procedimiento para  modificar  registros de categoria
       public void MODIFICARproducto(Producto P)
       {
           SqlDataAdapter da = new SqlDataAdapter();
           con.Open();

           da.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = P.nombre;
           
           da.UpdateCommand.Parameters.Add("@precioC", SqlDbType.Float).Value = P.precioC;
           da.UpdateCommand.Parameters.Add("@precioV", SqlDbType.Float).Value =P.precioV;
           da.UpdateCommand.Parameters.Add("@foto", SqlDbType.Binary).Value = P.foto;
           da.UpdateCommand.Parameters.Add("@idP", SqlDbType.VarChar).Value = P.idProducto;

           da.UpdateCommand.ExecuteNonQuery();
           con.Close();
       }
       // procedimiento para eliminar  registros de Categoria
       public void ELIMINARproducto(Producto P)
       {
           con = objCon.conecta();
           SqlDataAdapter da = new SqlDataAdapter();
           con.Open();

           da.DeleteCommand = new SqlCommand("delete from Productos where (idProducto=@idP)", con);
           da.DeleteCommand.Parameters.Add("@idP", SqlDbType.VarChar).Value = P.idProducto;

           try
           {
               da.DeleteCommand.ExecuteNonQuery();


           }
           catch (Exception x)
           {

           }
           finally
           {
               con.Close();
           }
       }

    }
}
