using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;
using CAPA_DATOS;
namespace CAPA_LOGICA_NEGOCIO
{
   public class CategoriaCN
    {
       CategoriaDAO objCate = new CategoriaDAO();
       public DataTable MostrarCATEGORIA()
       {
           return objCate.MOSTRARcategoria();
       }
       public void AGREGARcategoria(Categoria C)
       {
           objCate.AGREGARcategoria(C);
       }
       public void MODIFICARcategoria(Categoria C)
       {
           objCate.MODIFICARcategoria(C);
       }
       public void ELIMINARcategoria(Categoria C)
       {
           objCate.ELIMINARcategoria(C);
       }
    }
}
