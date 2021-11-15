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
   public class MarcaCN
    {
       MarcaDAO objMaCN = new MarcaDAO();

       public DataTable MOSTRARmarca()
       {
           return objMaCN.MOSTRARmarca();
       }
       public void AGREGARmarca(Marca M)
       {
           objMaCN.AGREGARmarca(M);
       }
       public void MODIFICARmarca(Marca M)
       {
           objMaCN.MODIFICARmarca(M);
       }
       public void ELIMINARmarca(Marca M)
       {
           objMaCN.ELIMINARmarca(M);
       }
    }
}
