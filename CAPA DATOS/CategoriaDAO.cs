using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CAPA_ENTIDAD;


namespace CAPA_DATOS
{
   public class CategoriaDAO
    {
        SqlConnection con;
        Conexion objCon = new Conexion();
        // mostrar estudiante  SELECT
        public DataTable MOSTRARcategoria()
        {
            con = objCon.conecta();
            SqlDataAdapter da = new SqlDataAdapter("select * from Categoria", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // INSERTAR UNA NUEVA CATEGORIA
        public void AGREGARcategoria(Categoria C)
        {
            con = objCon.conecta();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into Categoria values(@idCat, @DescC)", con);
            da.InsertCommand.Parameters.Add("@idCat", SqlDbType.VarChar).Value = C.idCategoria;
            da.InsertCommand.Parameters.Add("@DescC", SqlDbType.VarChar).Value = C.descripcionC;
            
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
        public void MODIFICARcategoria(Categoria C)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = new SqlCommand("update Categoria set DescripcionCat=@Desc where idCategoria=@idCat", con);

            da.UpdateCommand.Parameters.Add("@Desc", SqlDbType.VarChar).Value = C.descripcionC;
            da.UpdateCommand.Parameters.Add("idCat", SqlDbType.VarChar).Value = C.idCategoria;

            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
       // procedimiento para eliminar  registros de Categoria
        public void ELIMINARcategoria(Categoria C)
        {
            con = objCon.conecta();
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();

            da.DeleteCommand = new SqlCommand("delete from Categoria where (idCategoria=@idCat)", con);
            da.DeleteCommand.Parameters.Add("@idCat", SqlDbType.VarChar).Value = C.idCategoria;

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
