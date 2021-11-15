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
   public class MarcaDAO
    {
        SqlConnection con;
        Conexion objCon = new Conexion();
        // mostrar MARCA  SELECT
        public DataTable MOSTRARmarca()
        {
            con = objCon.conecta();
            SqlDataAdapter da = new SqlDataAdapter("select * from Marca", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // INSERTAR UNA NUEVA CATEGORIA
        public void AGREGARmarca(Marca M)
        {
            con = objCon.conecta();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into Marca values(@idM, @DescM,@foto)", con);
            da.InsertCommand.Parameters.Add("@idM", SqlDbType.VarChar).Value = M.idMarca;
            da.InsertCommand.Parameters.Add("@DescM", SqlDbType.VarChar).Value = M.descricionM;
            da.InsertCommand.Parameters.Add("@foto", SqlDbType.Binary).Value = M.fotoM;

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
        public void MODIFICARmarca(Marca M)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            da.UpdateCommand = new SqlCommand("update Marca set descripcionM=@Desc, fotoM=@foto where idMarca=@idMa", con);

            da.UpdateCommand.Parameters.Add("@Desc", SqlDbType.VarChar).Value = M.descricionM;
            da.UpdateCommand.Parameters.Add("@foto", SqlDbType.Binary).Value = M.fotoM;
            da.UpdateCommand.Parameters.Add("idMa", SqlDbType.VarChar).Value = M.idMarca;

            da.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
        // procedimiento para eliminar  registros de Categoria
        public void ELIMINARmarca(Marca M)
        {
            con = objCon.conecta();
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();

            da.DeleteCommand = new SqlCommand("delete from Marca where (idMarca=@idMa)", con);
            da.DeleteCommand.Parameters.Add("@idMa", SqlDbType.VarChar).Value = M.idMarca;

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
