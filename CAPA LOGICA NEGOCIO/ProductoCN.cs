using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias
using System.Data;
using System.Data.SqlClient;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_LOGICA_NEGOCIO
{
    public class ProductoCN
    {
        
        private ProductosDAO objProCN = new ProductosDAO();

        public DataTable MOSTRARproducto()
        {
            return objProCN.MOSTRARproducto();
        }
        public void AGREGARproducto(Producto p)
        {
            objProCN.AGREGARproducto(p);
        }
        public void MODIFICARproducto(Producto P)
        {
            objProCN.MODIFICARproducto(P);
        }
        public void ELIMINARproducto(Producto P)
        {
            objProCN.ELIMINARproducto(P);
        }
    }
}
