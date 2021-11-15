using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// LIBRERIAS
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
   public class ProductoCategoriaDAO
    {
        SqlConnection con;

        Conexion objCon = new Conexion();
        // mostrar CATEGORIA, MARCA POR PRODUCTO
       
        Marca objM = new Marca();
        Categoria objC = new Categoria();
        //public DataTable MOSTRARclasificacion(Marca M, Categoria C)
        //{
        //    con = objCon.conecta();
        //    SqlDataAdapter da = new SqlDataAdapter("select p.Nombre, pc.PrecioCompra, pc.PrecioVenta from Productos p join ProductoXcategoria pc on pc.idProducto=p.idProducto join Marca m on m.idMarca=pc.idMarca join Categoria c on c.idCategoria=pc.idCategoria where m.descripcionM=@descM and c.DescripcionCat=@descC", con);
        //    da.SelectCommand.Parameters.Add("@descM", SqlDbType.VarChar).Value = M.descricionM;
        //    da.SelectCommand.Parameters.Add("@descC", SqlDbType.VarChar).Value = C.descripcionC;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        // }

        public DataTable MOSTRARclasificacion1()
        {
            con = objCon.conecta();
            SqlDataAdapter da = new SqlDataAdapter("select pc.idClasificarP, p.Nombre, m.descripcionM, c.DescripcionCat from ProductoXcategoria pc join Productos p on p.idProducto=pc.idProducto join Marca m on m.idMarca=pc.idMarca join Categoria c on c.idCategoria=pc.idCategoria", con);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


        public void AGREGARproductoXcategoria(ProductoCategoria PC)
        {
            con = objCon.conecta();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into ProductoXcategoria values(@idclasi,@idProd, @idCat, @idMarca)", con);
            da.InsertCommand.Parameters.Add("@idclasi", SqlDbType.VarChar).Value = PC.clasi;
            da.InsertCommand.Parameters.Add("@idProd", SqlDbType.VarChar).Value = PC.idProducto;
            da.InsertCommand.Parameters.Add("@idCat", SqlDbType.VarChar).Value = PC.idCategoria;
            da.InsertCommand.Parameters.Add("@idMarca", SqlDbType.VarChar).Value = PC.idMarca;

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


        public void MODIFICARproductoXcategoria(ProductoCategoria PC)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = new SqlCommand("update ProductoXcategoria set idProducto=@idProd, idCategoria=@idCat, idMarca=@idMarca where idClasificarP=@idclasi", con);          
            da.UpdateCommand.Parameters.Add("@idProd", SqlDbType.VarChar).Value = PC.idProducto;
            da.UpdateCommand.Parameters.Add("@idCat", SqlDbType.VarChar).Value = PC.idCategoria;
            da.UpdateCommand.Parameters.Add("@idMarca", SqlDbType.VarChar).Value = PC.idMarca;
            da.UpdateCommand.Parameters.Add("@idclasi", SqlDbType.VarChar).Value = PC.clasi;
            try
            {
                da.UpdateCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
            }
            finally
            {
                con.Close();
            }
            
        }


        public void ELIMINARproductoXcategoria(ProductoCategoria PC)
        {
            con = objCon.conecta();
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();

            da.DeleteCommand = new SqlCommand("delete from ProductoXcategoria where (idClasificarP=@idclasi)", con);
            da.DeleteCommand.Parameters.Add("@idclasi", SqlDbType.VarChar).Value = PC.clasi;

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
