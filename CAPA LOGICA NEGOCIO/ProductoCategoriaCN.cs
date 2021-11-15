using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias
using System.Data;
using System.Data.SqlClient;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_LOGICA_NEGOCIO
{
   public class ProductoCategoriaCN
    {
        private ProductosDAO objProCN = new ProductosDAO();
        private ProductoCategoriaDAO objCxPCN =new  ProductoCategoriaDAO();

        /*
        public DataTable MOSTRARclasificacion(Marca M, Categoria C)
        {
            return objCxPCN.MOSTRARclasificacion1(M, C);
        }*/
        public DataTable MOSTRARclasificacion1()
        {
            return objCxPCN.MOSTRARclasificacion1();
        }

        public void AGREGARproductoXcategoria(ProductoCategoria PC)
        {
            objCxPCN.AGREGARproductoXcategoria(PC);
        }

        public void MODIFICARpxc(ProductoCategoria PC)
        {
            objCxPCN.MODIFICARproductoXcategoria(PC);
        }

        public void EliminarPxC(ProductoCategoria PC)
        {
            objCxPCN.ELIMINARproductoXcategoria(PC);
        }

    }
}
